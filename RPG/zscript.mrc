alias normaltopic {
  topic #sinisterswasteland 8,7|4,7|7,4|5,4|4,5|17,5|5,17|15,1#SinistersWasteland5,17|17,5|4,5|5,4|7,4|4,7|8,7|
}

on 1:kick:#: if ($knick == $me) join $chan

alias vote.kick {
  if (!%voting) { 
    set %voting 1
    hmake vote
    hadd vote voters $null
    hadd vote kickthis $1
    hadd vote reason $2-
    msg #sinisterswasteland Vote kick on $1 has started for reason: $2-
    timer 1 25 vote.endvote
  }
}

alias add.vote {
  if (!$istok($hget(vote,voters),$1,46)) {
    hadd vote voters $addtok($hget(vote,voters),$1,46)
    hadd vote $1 $+ .vote $2
    notice $1 Your vote has been cast.
  }
  else notice $1 You have allready voted!
}

alias vote.endvote {
  hadd vote numvotes $numtok($hget(vote,voters),46)
  if ($hget(vote,numvotes) > 0) {
    var %yes 0
    var %no 0
    hadd vote on 1
    while ($hget(vote,on) <= $hget(vote,numvotes)) {
      if ($hget(vote,$gettok($hget(vote,voters),$hget(vote,on),46) $+ .vote) == yes) var %yes $calc(%yes + 1)
      else var %no $calc(%no + 1)
      hadd vote on $calc($hget(vote,on) + 1)
    }
    if ($calc($calc(%yes \ $hget(vote,numvotes) * 100) > 50) && %yes > %no) {
      msg #sinisterswasteland Vote to kick $hget(vote,kickthis) succeeded.. %yes to %no $+ !
      ; kick #sinisterswasteland $hget(vote,kickthis) $hget(vote,reason)
    }
    else {
      msg #sinisterswasteland Kick vote failed. %yes to %no $+ .
    }
  } 
  else {
    msg #sinisterswasteland No one voted. Kick vote failed.
  }
  hfree vote
  set %voting 0
}

on *:text:!votekick*:*: {
  if (%votingenabled) vote.kick $2 $3-
}

on *:text:!vote yes:*: {
  if (%voting) add.vote $nick Yes
}

on *:text:!vote no:*: {
  if (%voting) add.vote $nick No
}

alias zsopen {
  hmake zs
  hmake zsusers
  hmake zstempban
  hmake zsban
  hload zsban $mircdir $+ zsban
  hload zsusers $mircdir $+ zsusers
  hadd zs port $read(C:\Dynamix6\TRIBES\config\ZSTELNET.cs,1)
  hadd zs port $remove($hget(zs,port),=)
  hadd zs port $remove($hget(zs,port),;)
  hadd zs port $remove($hget(zs,port),")
  window @zs
  sockopen zs 127.0.0.1 $hget(zs,port)
  aline 10 @zs ZS SOCKET OPENED PORT $hget(zs,port)
  hadd zs connected 0
  timer 1 1 zscheckconnect
}

alias zscheckconnect {
  if $hget(zs,connected) {
    timerzs off
  }
  else {
    zsclose
    zsopen
  }
}

alias zsclose {
  sockclose zs
  aline 5 @zs ZS SOCKET CLOSED PORT $hget(zs,port)
  hsave zsusers $mircdir $+ zsusers
  hsave zsban $mircdir $+ zsban
  hfree zs
  hfree zstempban
  hfree zsusers
  hfree zsban
}

on *:sockopen:zs: {
  if (!$sockerr) sockwrite -n zs 3483ASJFOIJEW2093
}

on *:sockread:zs: {
  if ($sockerr) {
    aline 4 @zs Error / Connection Lost
    zsclose
    zsopen
    halt
  }
  else {
    var %buff
    sockread -n %buff
    if ($gettok(%buff,1,32) == MSG:) {
      var %irc "(irc)
      var %server "Server:
      if ($gettok(%buff,2,32) != %irc) {
        if ($right($gettok(%buff,2,32),1) = : && $gettok(%buff,2,32) != %server) {
          msg #sinisterswasteland (zsdev) $right($gettok(%buff,2,32),$calc($len($gettok(%buff,2,32)) - 1)) $left($gettok(%buff,3-,32),$calc($len($gettok(%buff,3-,32)) - 1))
        }
      } 
    }
    if ($gettok(%buff,1,32) == ZS:SAY) {
      var %crop $gettok(%buff,2,58)
      var %crop $right(%crop,$calc($len(%crop) - 4))
      var %crop2 $gettok(%buff,3,58)
      var %crop2 $right(%crop2,$calc($len(%crop2) - 5))
      var %crop2 $remove(%crop2,")
      msg #sinisterswasteland (zsdev) %crop $+ : %crop2
    }
    if ($gettok(%buff,1,32) == ZSIRC:PLAYERS) {
      msg #sinisterswasteland (zsdev players) $gettok(%buff,2-,32)
    }
    if ($gettok(%buff,1,32) == ZSLOGIN) {
      var %name $zs.mvalid($gettok(%buff,2,32))
      var %password $zs.mvalid($gettok(%buff,3,32))
      zs.logincheck %name %password $gettok(%buff,4,32) $gettok(%buff,5,32)
    }
    if ($gettok(%buff,1,58) == ZSADDPOINTS) {
      var %name = $zs.mvalid($gettok(%buff,2,58))
      var %points = $gettok(%buff,3,58)
      zs.addpoints %name %points
    }
    if ($gettok(%buff,1,32) == ZSTEMPBAN) {
      echo -a TEMPBAN READ
      zs.tempban $zs.grabip($gettok(%buff,2,32)) $gettok(%buff,3,32) $gettok(%buff,4-,32)
    }
    if ($gettok(%buff,1,32) == ZSBAN) {
      echo -a BAN READ
      zs.ban $zs.grabip($gettok(%buff,2,32)) $gettok(%buff,3-,32)
    }
    if ($gettok(%buff,1,32) == ZSBANCHECK) {
      zs.checkbanned $zs.grabip($gettok(%buff,2,32)) $gettok(%buff,3,32)
    }
    if ($gettok(%buff,1,32) == ZSCHECKADMIN) {
      zs.checkadmin $gettok(%buff,2,32)
    }
    if (%buff != $null) {
      if ($hget(zs,connected) == 0) hadd zs connected 1
      aline 1 @zs %buff
    }
    if ($regex(%buff,MSG: "Server: Player \\"(.+)\\" added - id = .+"$)) {
      zsirc.playerjoined $regml(1) 1
    }
    if ($regex(%buff,MSG: "Server: Player \\"(.+)\\" dropped - id = .+"$)) {
      zsirc.playerjoined $regml(1) 0
    }
    if (%buff == ZSSAVE) {
      hsave zsusers $mircdir $+ zsusers
    }
    if ($gettok(%buff,1,32) == ZSADMINME) {
      zs.adminme $gettok(%buff,2,32) $gettok(%buff,3,32)
    }
  }
}

;-------------------------------------------------------------------------

alias zsirc.playerjoined {
  if ($2 == 1) {
    aline 12 @zs Player Joined: $zs.mvalid($1)
    msg #sinisterswasteland (zsdev) $zs.mvalid($1) connected to the server.
  }
  else {
    aline 12 @zs Player Dropped: $zs.mvalid($1)
    msg #sinisterswasteland (zsdev) $zs.mvalid($1) dropped.
  }
}

;-------------------------------------------------------------------------

alias zs.grabip {
  return $gettok($1,2,58)
}

alias secticks {
  return $left($1,$calc($len($1) - 3))
}

alias zs.adminme {
  if ($hget(zsusers,$1 $+ .admin) == 1) {
    sockwrite -n zs zs::AdminUp(" $+ $1 $+ ", $+ $2 $+ );
  }
  else {
    sockwrite -n zs zs::KickBadAdminLogin( $+ $2 $+ );
  }
}

alias zs.checkadmin {
  ; echo -a CHECKING ADMIN
  if ($hget(zsusers,$1 $+ .admin) == 1) {
    ; echo -a IS ADMIN
    sockwrite -n zs zs::isAdmin(" $+ $1 $+ ");
  }
}

alias zs.listadmins {
  var %people $numtok($hget(zsusers,list),46)
  echo -a %people Players
  var %admins $null
  while (%people > 0) {
    ; echo -a $gettok($hget(zsusers,list),%people,46)
    if ($hget(zsusers,$gettok($hget(zsusers,list),%people,46) $+ .admin) == 1) {
      echo -a 10 Admin $gettok($hget(zsusers,list),%people,46)
    }
    dec %people
  }
}

alias zs.listplayers {
  echo -a --------------------------------------------
  echo -a 12 Listing all ZS Players.. 10 (Admins)
  var %people $numtok($hget(zsusers,list),46)
  echo -a 12 %people Players
  if ($1 == $null) {
    while (%people > 0) {
      if ($hget(zsusers,$gettok($hget(zsusers,list),%people,46) $+ .admin) == 1) {
        echo -a 10 $+ $gettok($hget(zsusers,list),%people,46)
      }
      else { 
        echo -a $gettok($hget(zsusers,list),%people,46)
      }
      dec %people
    }
  }
  else {
    hmake zstemp
    var %list $null
    var %liston 0
    var %thelist 0
    hadd zstemp people %people
    while ($hget(zstemp,people) > 0) {
      if ($hget(zsusers,$gettok($hget(zsusers,list),%people,46) $+ .admin) == 1) {
        var %list $+ %thelist %list $+ %thelist $+ $chr(32) $+ 10 $+ $gettok($hget(zsusers,list),$hget(zstemp,people),46)
      }
      else {
        var %list $+ %thelist %list $+ %thelist $+  $chr(32) $+ 1 $+ $gettok($hget(zsusers,list),$hget(zstemp,people),46)
      }
      inc %liston
      if (%liston > 15) {
        inc %thelist
      }
      hadd zstemp people $calc($hget(zstemp,people) - 1)
    }
    echo -a %list0
    hfree zstemp
  }
  echo -a --------------------------------------------
}

alias zs.deleteplayer {
  if ($1 != $null) {
    if ($istok($hget(zsusers,list),$1,46)) {
      var %find $findtok($hget(zsusers,list),$1,1,46)
      hadd zsusers list $deltok($hget(zsusers,list),%find,46)
      hdel zsusers $1 $+ .admin
      echo -a 4 $1 account was deleted.
      hsave zsusers $mircdir $+ zsusers
    }
    else {
      echo -a 4 $1 is not a player on the list.
    }
  }
}

alias zs.playerstats {
  if ($1 != $null) {
    if ($istok($hget(zsusers,list),$1,46)) {
      echo -a ---------------------------------
      echo -a 5 Stats for $1
      echo -a IP: $hget(zsusers,$1 $+ .ip)
      echo -a Points: $hget(zsusers,$1 $+ .score)
      echo -a Admin: $hget(zsusers,$1 $+ .admin)
      echo -a ---------------------------------
    }
    else {
      echo -a 4 $1 is not a player on the list
    }
  }
}

alias zs.addadmin {
  if ($1 != $null) {
    if ($istok($hget(zsusers,list),$1,46)) {
      hadd zsusers $1 $+ .admin 1
      echo -a 10 Added admin $1
      hsave zsusers $mircdir $+ zsusers
    }
    else {
      echo -a 4 $1 is not a player on the list.
    }
  }
}

alias zs.removeadmin {
  if ($1 != $null) {
    if ($istok($hget(zsusers,list),$1,46)) {
      if ($hget(zsusers,$1 $+ .admin) == 1) {
        hdel zsusers $1 $+ .admin
        echo -a 10 $1 is no longer an admin.
        hsave zsusers $mircdir $+ zsusers
      }
      else {
        echo -a 4 $1 does not have admin status.
      }
    }
    else {
      echo -a 4 $1 is not a player on the list.
    }
  }
}

alias zs.tempban {
  echo -a 13 ALIAS TEMPBAN
  ; ip seconds reason
  aline 13 @zs TEMP BANNING $1 for $2 SECONDS - REASON: $3-
  hadd zstempban list $addtok($hget(zstempban,list),$1,32)
  hadd zstempban $1 $+ _endban $calc($secticks($ticks) + $2)
  hadd zstempban $1 $+ _reason $3-
}

alias zs.ban {
  aline 4 @zs BANNING $1 REASON: $2-
  hadd zsban list $addtok($hget(zsban,list),$1,32)
  hadd zsban $1 $+ _reason $2-
  hsave zsban $mircdir $+ zsban
}

alias zs.listbans {
  echo -a 4 LISTING BANS
  echo -a 4 BANS: $hget(zsban,list)
  echo -a 4 TEMP BANS: $hget(zstempban,list)
}

alias zs.removeban {
  if ($1 != $null) {
    echo -a 4 Removing Ban $1
    if ($istok($hget(zsban,list),$1,32)) {
      var %find $findtok($hget(zsban,list),$1,1,32)
      hadd zsban list $remtok($hget(zsban,list),$1,1,32)
      echo -a 4 Removed $1 from the ban list!
    }
    else {
      echo -a 4 $1 is not on the ban list!
    }
  }
  else {
    echo -a 4 You must specify an IP to remove!
  }
}

alias zs.removetempban {
  if ($1 != $null) {
    echo -a 4 Removing Temp Ban $1
    if ($istok($hget(zstempban,list),$1,32)) {
      var %find $findtok($hget(zstempban,list),$1,1,32)
      hadd zstempban list $remtok($hget(zstempban,list),$1,1,32)
      echo -a 4 Removed $1 from the temp ban list!
    }
    else {
      echo -a 4 $1 is not on the temp ban list!
    }
  }
  else {
    echo -a 4 You must specify an IP to remove!
  }
}

alias zs.checkbanned {
  ; ip clientid
  if ($istok($hget(zsban,list),$1,32)) {
    var %reason $hget(zsban,$1 $+ _reason);
    sockwrite -n zs zs::isBanned( $+ $2 $+ ," $+ %reason $+ ");
  }
  if ($istok($hget(zstempban,list),$1,32)) {
    var %remain $calc($hget(zstempban,$1 $+ _endban) - $secticks($ticks))
    if (%remain > 0) {
      var %reason $hget(zstempban,$1 $+ _reason);
      sockwrite -n zs zs::isTempBanned( $+ $2 $+ , $+ %remain $+ ," $+ %reason $+ ");
    }
    else {
      zs.removetempban $1
    }
  }
}

;-------------------------------------------------------------------------

alias zs.mvalid {
  var %1 $1-
  var %1 $replace(%1,$chr(32),_)
  var %1 $replace(%1,$chr(36),_)
  var %1 $replace(%1,$chr(37),_)
  var %1 $replace(%1,$chr(34),_)
  var %1 $replace(%1,$chr(46),_)
  return %1
}

alias zs.addpoints {
  aline 4 @zs [adding points] $1 $2
  hadd zsusers $1 $+ .score $calc($hget(zsusers,$1 $+ .score) + $2)
}

alias zs.logincheck {
  aline 4 @zs [zslogincheck] $1 $2 $3 $4
  var %id $3
  var %ip $zs.grabip($4)
  aline 7 @zs %ip
  if ($hget(zsusers,$1 $+ .password) == $2) {
    hadd zsusers $1 $+ .ip $addtok($hget(zsusers,$1 $+ .ip),%ip,32)
    sockwrite -n zs zs::Login(" $+ $1 $+ ", $+ %id $+ , $+ $hget(zsusers,$1 $+ .score) $+ );
  }
  elseif ($hget(zsusers,$1 $+ .password) == $null) {
    hadd zsusers $1 $+ .ip $addtok($hget(zsusers,$1 $+ .ip),%ip,32)
    zs.newuser $1 $2 %id
  }
  elseif ($hget(zsusers,$1 $+ .password) != $2) {
    sockwrite -n zs zs::WrongPassword( $+ %id $+ );
  }
}

alias zs.newuser {
  hadd zsusers list $addtok($hget(zsusers,list),$1,46)
  hadd zsusers $1 $+ .password $2
  hadd zsusers $1 $+ .score 0
  sockwrite -n zs zs::newUser(" $+ $1 $+ "," $+ $2 $+ ", $+ $3);
}

;-------------------------------------------------------------------------

alias zs.stats {
  if ($istok($hget(zsusers,list),$1,46)) {
    msg #sinisterswasteland 4,1 ZS STATS  $1 4,1 Score 4 $hget(zsusers,$1 $+ .score)
  }
}
;-------------------------------------------------------------------------

on *:text:!fuckyoulotz:*: {
  msg #sinisterswasteland No FUCK YOU $nick $+ !
}

on *:text:!zs*:*: {
  if ($1 == !zsstats) {
    zs.stats $2
  }
  elseif ($1 == !zsusers) {
    sockwrite -n zs zs::ircUsers();
  }
  else {
    var %msg $replace($2-,",\")
    sockwrite -n zs ircChat(" $+ $nick $+ "," $+ %msg $+ ");
  }
}

on *:input:!zs*:*: {
  if ($1 == !zsusers) {
    sockwrite -n zs zs::ircUsers();
  }
  else {
    var %msg $replace($2-,",\")
    sockwrite -n zs ircChat(" $+ $nick $+ "," $+ %msg $+ ");
  }
}

on 1:disconnect: {
  zsclose
}

on 1:connect: {
  zsopen
}

;-------------------------------------------------------------------------
