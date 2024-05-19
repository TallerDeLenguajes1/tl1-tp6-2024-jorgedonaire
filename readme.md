*Ejercicio 4*

¿String es una tipo por valor o un tipo por referencia?
Respuesta: En C#, las cadenas de texto (string) son un tipo especial. Aunque string es una clase y, por lo tanto, un tipo por referencia, tiene un comportamiento peculiar que lo hace parecer en algunos aspectos un tipo por valor.

¿Qué secuencias de escape tiene el tipo string?
Respuesta:

(todo entre comillas ''
)
"\" : Representa una comilla doble dentro de una cadena de texto.
\\ : Representa una barra invertida literal.
\n : Representa un salto de línea (newline).
\r : Representa un retorno de carro (carriage return).
\t : Representa una tabulación horizontal (tab).
\a : Representa una alarma o campanilla (bell).
\b : Representa un retroceso (backspace).
\f : Representa una alimentación de formulario (form feed).
\0 : Representa un carácter nulo.
\u : Representa un carácter Unicode específico, donde xxxx es el código hexadecimal de 4 dígitos.
\U : Representa un carácter Unicode específico, donde xxxxxxxx es el código hexadecimal de 8 dígitos.

¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Respuesta:

Cadena Verbatim (@)
Cuando se utiliza el carácter @ antes de una cadena de texto, se crea una cadena verbatim (cadena literal), que tiene las siguientes características:

Ignora las secuencias de escape: Las secuencias de escape (\n, \t, etc.) se tratan como caracteres literales.
Permite múltiples líneas: Puedes escribir la cadena en varias líneas sin necesidad de concatenar con +.
Doblar comillas dobles: Las comillas dobles dentro de la cadena deben ser dobladas ("") para representar una sola comilla doble.

Cuando se utiliza el carácter $ antes de una cadena de texto, se habilita la interpolación de cadenas, lo que permite insertar expresiones dentro de la cadena usando llaves {}. Las expresiones dentro de las llaves se evalúan y su resultado se inserta en la cadena.

@$ o $@ antes de una cadena combina ambas características, permitiendo una cadena verbatim interpolada.
