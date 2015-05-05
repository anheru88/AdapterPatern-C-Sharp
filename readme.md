# Taller Patron Adaptador

### Enunciado
Usted ha creado una aplicación **(con GUI)** que debe guardar cierta información acerca de un grupo de estudiantes **(Nombre, Código, Edad, Sexo, Dirección)** en memoria. Además de esto, la aplicación podrá en cualquier momento buscar un estudiante **_(por nombre)_** específico en el lugar donde haya guardado la información respectiva. Para lo anterior Usted decide utilizar un **_ArrayList<Estudiante>_ (_List<Estudiante>_ en C#).**

Sin embargo luego de esto Ud. decide que es tiempo de cambiar la estructura de datos
utilizada por un **_HashMap<String,Estudiante>_** **(_Dictionary en C#_)** por razones de performance, pero intuye que es posible que en el futuro pueda cambiar nuevamente dicha estructura por otra más adecuada. Para no afectar el resto de la aplicación y teniendo en cuenta que las interfaces de acceso de **_ArrayList/List** y **_HashMap/Dictionary_** no son compatibles, Ud. decide utilizar el patrón Adapter, definiendo una interfaz unificada de acceso al almacén de información en memoria.

Implemente la aplicación del caso **(incluyendo la interfaz gráfica de usuario)** haciendo uso del patrón Adapter para lograr las metas de diseño planteadas.

Recuerde que debe proporcionar el código fuente y un diagrama de clases UML que detalle
la estructura de la solución planteada.

### Imagenes de la Aplicacion

![Imagen 1](/Images/1.png "Imagen 1")

![Imagen 2](/Images/2.png "Imagen 2")

![Imagen 3](/Images/3.png "Imagen 3")

![Imagen 4](/Images/4.png "Imagen 4")

![Imagen 5](/Images/5.png "Imagen 5")

![Imagen 6](/Images/6.png "Imagen 6")

### Diagrama UML y Clases

![Digrama de Clases](/Images/ClassDiagram1.png "Diagrama de Clases")

![Estructura de Directorios](/Images/DirectoryStructure.png "Estructura de Directorios")