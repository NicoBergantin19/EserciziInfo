<?php
//se non in post back, submit è nullo, solo con il submit si effettua il post back
//header("location:visualizza.php")
if ($_POST) {
    if (isset($_POST["submit"])) //variabile superglobale
    {
        $user = $_POST["username"];
        $pws = $_POST["password"];
        $conDB = mysqli_connect('localhost', 'root', NULL, 'gestore'); //in 5.5 mysqli-connect
        //se la connessione va a buon fine è true altrimenti false
        if ($conDB) //se true
        {
            echo "connessione effettuata";
        } else {
            die("impossibile connettersi");
        }
        $ris = mysqli_query($conDB, "INSERT INTO utente(username,pws) VALUES ('$user','$pws')");
        if ($ris) {
        } else {
            echo "inserimento fallito" . mysqli_error($conDB);
        }
        mysqli_close($conDB);
    }
    if (isset($_POST["invia"])) {
        $conDB = mysqli_connect('localhost', 'root', NULL, 'gestore');
        //stampare il risultato della query
        $record_set = mysqli_query($conDB, "SELECT * FROM utente");
        //formattare in tabella
        echo "<table border=1><tr><th>ID</th><th>username</th><th>password</th></tr>";
        while ($riga = mysqli_fetch_assoc($record_set)) //i dizionari sono array associativi, si passa il recordset nella assoc
        {
            echo "<tr><td>" . $riga['ID'] . "</td><td>" . $riga['username'] . "</td><td>" . $riga['pws'] . "</td></tr>";
        }
        echo "</table>";
        mysqli_close($conDB);
        header("Location:visualizza.php");
    }
}
?>

<html>

<head>

    <title>PAGINA DI LOGIN</title>
</head>

<body>
    <h2>INSERIMENTO DATI</h2>
    <form action="login51.php" method="POST">
        <label for="username">NOME UTENTE</label>
        <input type="text" name="username"> </br></br>

        <label for="password">PASSWORD</label>
        <input type="text" name="password"> </br></br>

        <input type="submit" name="submit" value="invia">
        <nbsp></nbsp>
        <input type="submit" name="invia" value="visualizza"></br>
        <!--controllare se si ha effettivamente inviato qualcosa -->

    </form>
</body>



</html>