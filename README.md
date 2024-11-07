# Prueba Técnica: Desarrollo de una Web API en C#/.NET

## Objetivo

El propósito de esta prueba técnica es desarrollar una Web API básica que permita realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre un recurso de tipo `Product`.

---

## Requisitos

### Configuración del Proyecto

1. **Crear un nuevo proyecto** de tipo `ASP.NET Core Web API`.
2. **Configurar Swagger** para la documentación automática de la API.

### Modelo de Datos

Crear una clase `Product` con las siguientes propiedades:

- `Id` (int, auto-incremental)
- `Name` (string, requerido)
- `Price` (decimal, requerido)
- `Quantity` (int, requerido)

### Operaciones CRUD

Implementar los siguientes endpoints en la API:

- **GET** `/api/products`: Obtener una lista de todos los productos.
- **GET** `/api/products/{id}`: Obtener un producto por su ID.
- **POST** `/api/products`: Crear un nuevo producto.  
  El cuerpo de la solicitud debe incluir `Name`, `Price` y `Quantity`.
- **PUT** `/api/products/{id}`: Actualizar un producto existente.
- **DELETE** `/api/products/{id}`: Eliminar un producto por su ID.

---

## Persistencia

Utilizar una lista en memoria para almacenar los productos. No es necesario el uso de una base de datos.

---

## Validaciones

Implementar validaciones básicas:

- `Name` no debe estar vacío.
- `Price` y `Quantity` deben ser mayores a cero.

---

## Documentación

- Utilizar **Swagger** para generar automáticamente la documentación de la API, mostrando los endpoints y los modelos de datos.

---

## Entrega

El código fuente del proyecto debe enviarse en uno de los siguientes formatos:

1. Archivo ZIP con el código.
2. Repositorio en GitHub o Bitbucket (proporcionar el enlace).

---

## Criterios de Evaluación

- **Calidad del Código**: Claridad, legibilidad y uso de buenas prácticas.
- **Funcionamiento de la API**: Correcta implementación de las operaciones CRUD.
- **Buenas Prácticas de API**: Diseño RESTful, manejo adecuado de peticiones y respuestas.
- **Manejo de Errores**: Validaciones y gestión de errores robusta.
- **Documentación**: Completa y clara, con Swagger.

---


## Cómo Ejecutar el Proyecto

1. **Clonar el repositorio** o descomprimir el archivo ZIP.
2. **Abrir el proyecto** en Visual Studio.
3. **Ejecutar el proyecto** (F5).
4. Acceder a la documentación de Swagger en `http://localhost:{puerto}/swagger/ui/index#/`.
   Por ejemplo: https://localhost:44338/swagger/ui/index#/
---

## Autor

[Carlos Eduardo Alvear Mutis](mailto:alvearmutis@outlook.es)
