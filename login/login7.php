<?php 
//PHP 7
//se non in post back, submit è nullo, solo con il submit si effettua il post back
if ($_POST) //se è il ritorno del file, dopo il submit
{
    $user=$_POST["username"];
    $pws=$_POST["password"];
    $conDB= new mysqli('localhost','root',NULL,'gestore');//in 5.5 mysqli-connect
    //se la connessione va a buon fine è true altrimenti false
    if(mysqli_connect_errno()) //controlla se c'è un errore nella connessione al DB
    { //se è vera
        echo "connessione fallita:".mysqli_connect_errno()."</br></br>";
        exit(1);
    }
    $ris=$conDB->query("INSERT INTO utente(username,pws) VALUES ('$user','$pws')");
    if($ris)
    {
        echo "operazione eseguita";
    }
    else{
        echo "inserimento fallito".mysqli_error($conDB);
    }


}
?>

//FRANCESCO TOTTI

<html>
<head>
    
    <title>PAGINA DI LOGIN</title>
</head>
<body>
    <h2>INSERIMENTO DATI</h2>
    <form action="login7.php" method="POST">
    <label for="username">NOME UTENTE</label>
    <input type="text" name="username"> </br></br>

    <label for="password">PASSWORD</label>
    <input type="text" name="password"> </br></br>

    <input type="submit" name="submit" value="invia"></br></br>
    <!--controllare se si ha effettivamente inviato qualcosa -->

    </form>
</body>



</html>