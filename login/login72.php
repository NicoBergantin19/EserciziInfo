<!DOCTYPE html>
<html lan="IT">
<header>
    <meta charset="UTF-8">
    <title>PAGINA DI LOGIN</title>
</header>
<body>

<?php
if(isset($_POST["submit"]))
{
$user=$_POST["username"];
$pws=$_POST["password"];
try
{
    $conDB=new mysqli('localhost','root',NULL,'gestore');//in 5.5 mysqli-connect
    echo "connessione effettuata"."<br>";
}
catch (Exception $x)
{
    if(mysqli_connect_errno())
    {
        echo "connessione fallita".mysqli_connect_errno()."<br>";
        exit(1);
    }
}
//inserimento dati
try
{
    $ris = $conDB->query("INSERT INTO utente(username,pws) VALUES ('$user','$pws')");
    echo "inserimento eseguito"."<br>";
}
catch(Exception $x)
{
    die("query fallita:".$x);
    
}
$conDB->close();
}
else
{
//se non sono in postback
echo "<body>
<h2>INSERIMENTO DATI</h2>
<form action='".$_SERVER['PHP_SELF']."' method='POST'>
<label for='username'>NOME UTENTE</label>
<input type='text' name='username'> </br></br>

<label for='password'>PASSWORD</label>
<input type='text' name='password'> </br></br>

<input type='submit' name='submit' value='invia'></br></br>
<!--controllare se si ha effettivamente inviato qualcosa -->

</form>
</body>";
}


?>


</body>





</html>