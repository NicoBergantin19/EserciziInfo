<?php
/*invece che utilizzare l'header scrivo un echo ahref 
ci mettiamo il visualizza.php?nomevar=username o
 password a seconda di quello che si vuole visualizzare
*/
if (isset($_POST["submit"])) //variabile superglobale
{
    $user=$_POST["username"];
    $pws=$_POST["password"];
    $conDB=mysqli_connect('localhost','root',NULL,'gestore');//in 5.5 mysqli-connect
    //se la connessione va a buon fine è true altrimenti false
    if($conDB) //se true
    { 
        echo "connessione effettuata";
    }
    else
    {
        die("impossibile connettersi");
    }
}
?>