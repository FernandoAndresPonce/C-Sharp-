       // console.log("Hola Mundo");
        //funciion, no se pone el tipo de dato, asi a secas.
        function saludar()
        {
            let user = document.getElementById("txtUser").value; // de esta manera guardo el valor de la caja de texto, en la variable user.
            let password = document.getElementById("txtPassword").value;
            alert("Te damos la bienvenida " + user);
            console.log("La password es " + password);
            
        }
        function sumar()
        {
            let n1 = parseInt(document.getElementById("txtUser").value); 
            let n2 = parseInt(document.getElementById("txtPassword").value);
            alert("La suma es " + (n1 + n2));
        }