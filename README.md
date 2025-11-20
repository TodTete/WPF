# 📦 WPF CRUD con MVVM y MySQL

Una aplicación de escritorio desarrollada en **C#** utilizando el patrón de diseño **MVVM** con **WPF**. Este proyecto permite gestionar usuarios mediante operaciones **CRUD** (Crear, Leer, Actualizar y Eliminar) conectadas a una base de datos **MySQL**.

## 🧠 Tecnologías utilizadas

* ⚙️ **WPF (.NET)**
* 🧱 **MVVM (Model-View-ViewModel)**
* 🗄️ **MySQL**
* 🔌 **MySql.Data** (conector oficial)

## 🧾 Funcionalidades

* 👤 Registrar nuevo usuario
* 🔍 Listar todos los usuarios
* ✏️ Editar información de usuario
* ❌ Eliminar usuario de la base de datos
* 🔒 Validaciones básicas en la vista

## 🖥️ Modelo de datos (UserModel)

```csharp
public class UserModel : INotifyPropertyChanged
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surnames { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
```

## 🧩 MVVM en acción

El proyecto sigue el patrón **MVVM**, separando las responsabilidades en:

* **Model** → Representa los datos.
* **ViewModel** → Maneja la lógica de negocio y conecta la vista con el modelo.
* **View** → La interfaz de usuario definida en XAML.

## 🛠️ Requisitos

* Visual Studio 2022 o superior
* .NET Desktop Development
* Servidor MySQL activo
* Conexión configurada en `DatabaseService.cs`

## 🔐 Seguridad

La contraseña se maneja como texto por simplicidad en el proyecto; se recomienda aplicar cifrado en entornos reales.

## ©️ Autor 
Realizado por Ricardo Vallejo Sánchez **@TodTete**
