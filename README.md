# Figuras Geométricas

## Descripción del Proyecto
StickerBoard es una aplicación desarrollada en C# Windows Forms permite al usuario dibujar figuras geométricas básicas (rectángulo, círculo, triángulo y línea) sobre un lienzo.
 El usuario puede seleccionar el tipo de figura, color, tamaño, establecer coordenadas iniciales y finales (en caso de línea), y limpiar el lienzo para reiniciar el conteo de figuras creadas.
Este proyecto forma parte de la asignatura Herramientas de Programación II y aplica conceptos de programación orientada a objetos, manejo de eventos y dibujo con System.Drawing.

## Tecnologías Utilizadas
Lenguaje: C#
Framework: .NET Windows Forms
IDE recomendado: Visual Studio

### Librerías:
-System.Drawing (para gráficos)
-System.Windows.Forms (para interfaz gráfica)
-Clases personalizadas (Figura, FiguraFactory, Rectangulo,Triangulo,Circulo,Linea)

## Controles  Usados
-ComboBox
-cmbFigura
-Tipos de figuras: Rectángulo, Círculo, Línea, Triángulo.
-NumericUpDown
-nudX, nudY
-Posición base (coordenadas X, Y).
-NumericUpDown
-nudTamaño
-Tamaño para Rectángulo, Círculo y Triángulo. Se deshabilita si la figura es Línea.
-NumericUpDown
-nudX2, nudY2
-Segundo punto (X2, Y2) solo cuando la figura es Línea.
-PictureBox
-pbLienzo
-Área de dibujo.
-PictureBox
-pbColor
-Vista previa del color seleccionado (abre ColorDialog).
-ColorDialog
-colorDialog1
-Selección de color.
-Button
-btnCrear
-Dibuja la figura en el lienzo.
-Button
-btnLimpiar
-Limpia el lienzo y reinicia el contador.
-TextBox
-txtContador
-Muestra cantidad total de figuras creadas (solo lectura).

## Ejecución: 
Ejecutar StickerBoard
Seleccionar tipo, color y tamaño.
Presionar “Crear” para dibujar el sticker.
Limpiar con “Limpiar lienzo”.

## Autores
Juan Diego Naranjo Mora, 
Alejandro Giraldo Salazar, 
Grupo: G-002, 
Asignatura: Herramientas de Programacion II, 
Semestre 4 


# Capturas de la aplicación funcionando (casos de prueba)
![Imagen de aplicacion en funcionamiento](https://github.com/Tenkazito/wFiguras/blob/main/images/image1.png)
![Imagen de aplicacion en funcionamiento](https://github.com/Tenkazito/wFiguras/blob/main/images/image2.png)
![Imagen de aplicacion en funcionamiento](https://github.com/Tenkazito/wFiguras/blob/main/images/image3.png)
![Imagen de aplicacion en funcionamiento](https://github.com/Tenkazito/wFiguras/blob/main/images/image4.png)
![Imagen de aplicacion en funcionamiento](https://github.com/Tenkazito/wFiguras/blob/main/images/image5.png)
![Imagen de aplicacion en funcionamiento](https://github.com/Tenkazito/wFiguras/blob/main/images/image6.png)
![Imagen de aplicacion en funcionamiento](https://github.com/Tenkazito/wFiguras/blob/main/images/image7.png)
