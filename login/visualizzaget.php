<?php
$headerHTML="<html><head><title>VISUALIZZA</title></head><body>";
echo $headerHTML;
$conDB=new mysqli('localhost','root',NULL,'gestore');//in 5.5 mysqli-connect
//se la connessione va a buon fine è true altrimenti false
if($conDB) //se true
{ 
    echo "connessione effettuata";
}
else
{
    die("impossibile connettersi");
}


if(isset($_GET["username"]))
{
    $record_set=$conDB->query("SELECT ID,username FROM utente");
    //formattare in tabella
    echo "<table border=1><tr><th>ID</th><th>username</th></tr>";
    foreach($record_set as $riga) //i dizionari sono array associativi, si passa il recordset nella assoc
    {
        echo "<tr><td>".$riga['ID']."</td><td>".$riga['username']."</td></tr>";
    }
    echo "</table>";
    echo "</body></html>";
}
else
{
    if($_GET["password"]==1)
    {
        $record_set=$conDB->query("SELECT ID,pws FROM utente");
        //formattare in tabella
        echo "<table border=1><tr><th>ID</th><th>password</th></tr>";
        foreach($record_set as $riga) //i dizionari sono array associativi, si passa il recordset nella assoc
        {
            echo "<tr><td>".$riga['ID']."</td><td>".$riga['pws']."</td></tr>";
        }
        echo "</table>";
        echo "</body></html>";
    }
}

?>