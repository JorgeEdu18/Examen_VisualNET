# Examen Visual .NET
![logo uaz](https://i1.rgstatic.net/ii/profile.image/673265882247174-1537530503289_Q128/Miguel-Garcia-Guerrero.jpg)
--------------------------------------------------------------------------------------------- 

### **Jorge Eduardo Chávez Zárate**
### **4°B**
### **38196280**
### **Visual .NET**
---------------------------------------------------------------------------------------------
# Problema:
Juego Ruleta 
Carlos es un programador y apasionado jugador de juegos de azar en los casinos, especialmente la ruleta y todo lo que tiene que ver con la estadística detrás de este juego.Le gustaría crear su propio juego de ruleta en su computadora que innove la industria, pero para llegar a ese punto cree que es necesario primero desarrollar un pequeño juego básico de apuestas con una ruleta. 

# Solucion
-------------------------------------------------------
  ## Analisis:

  Al analizar la problematica realize 3 clases en las cual resolveria la problematica, las clases contienen soluciones a las carecteristicas ya mencionadas en la problematica. Me decidi por tres clases, ya que no es un prblema demaciado grande como para tener más clases.
  En el siguiente diagrama se muestran la relaciones que tienen una clase con otra.
-------------------------------------------------------
  ## Diagrama UML
![Diagrama UML](https://user-images.githubusercontent.com/78887656/158501571-7e6625cf-4c4a-422f-97cb-f420d0d8aa03.png)
-------------------------------------------------------
  ## Metododos
  
  ### **Programs.cs ** Es la clase en la cual se inicializa el programa

  ### Clase ruleta: 
  En este metodo es para generar el juego de la ruleta, en esta clase contiene 9 metodos:
  * El metodo **ruleta** que funciona para inicializar la clase      
  * **ImprimirTablero:** Su funcion es la de imprimir el tablero, este metodo recibe valor, este valor es donde cayo la bola que sera representado con una x
  * **Girar** Es el en la cual realiza todo el proceso que haría una ruleta de verdad, al ser llamada esta recibe la cantidad la cual aposto el jugador y que tipo de apuesta va a realizar. Este metodo llama a varios metodos de la misma clase como de otra clases
  *  **EsPar** Es la metodo que evalua si un numero es par.
  *  **EsBolaNegra** Es el metodo en el cual evalua si e una bola negra
  *  **ImprimirGiros** Imprime los giros
  *  **Estadistica** Imprime al jugador las estadisticas del juego
  *  **ElementosRepetidos** Evalua que numero es el más repetido y cual no
  ### Clase Dinero:
  Esta clase su funcion es la de hacer los calculos de de ganancia, perdida y balance del dinero del jugador.
  * **Mostrar dinero** Imprime la cantidad actual de dinero del jugador
  * **Ganancias** En este metodo recibe el porcentaje de ganancia, la cantidad apostada y el numero de giro al ganar la apuesta, a partir de esto hace el calculo de su ganancia
  * **Perdidad** En este metodo recibe la cantidad apostada y el numero de giro al ganar la apuesta, a partir de esto hace el calculo de su perdida
  * **TieneDIner** Evalua si el jugador tiene más de 10 para poder jugar
  * **Multiplo10** Evalua la apuesta para determinar si es mmultiplo de 10.
  * **ImprimirResultados** Imprime todos lo resultados que ha tenido el jugador 
  ### Clase Menu:
  En la clase menu su funcion es la de imprimir el menu y leer lo que el jugadror selecciona, esta a la vez llama al metod al cual el jugador llama
  -------------------------------------------------------
  ## Capturas.
  ![image](https://user-images.githubusercontent.com/78887656/158503748-bb9bdcd7-7357-43e6-8e9c-6ad6d7475540.png)
  ###### (Iniciando programa)
  -------------------------------------------------------
  ![image](https://user-images.githubusercontent.com/78887656/158503874-fd8e9bfb-b2bc-4167-8d2d-f98488a3b0bd.png)
  ###### (Jugador apostando)
  -------------------------------------------------------
  ![image](https://user-images.githubusercontent.com/78887656/158503984-6bcc92b1-76f5-452a-961a-289caabd4bb7.png)
  ###### (Giros totales)
  -------------------------------------------------------
  ![image](https://user-images.githubusercontent.com/78887656/158504042-2c6c0231-fff3-4c73-b880-8ee00ff09dfb.png)
  ###### (Balance dinero)
  -------------------------------------------------------
  ![image](https://user-images.githubusercontent.com/78887656/158504129-65b99f61-e23e-4da4-9db0-215f31f5f73a.png)
  ###### (Estadisticas del juego)
  -------------------------------------------------------
![image](https://user-images.githubusercontent.com/78887656/158505499-b611e14b-6b25-4db7-b235-d96782b178b4.png)
  ###### (Elementos repetidos en el juego)
  



---
---
