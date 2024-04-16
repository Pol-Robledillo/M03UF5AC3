# M03UF5AC3
## Fuentes
- ChatGPT. (s. f.-b). [ChatGPT)](https://chat.openai.com/)
- Raquel Alamán Navas. (2024, 7 abril). M03 UF5 Teoría. UF5. POO. Classes fonamentals i persistència en BD. M03.UF5. [Teoria](https://docs.google.com/document/d/1JJhB0bqxqns69wKZyF-s8eacxkzv55gO-ez6QvXEvhw/edit#heading=h.4heg8liyhxx)
- Pol Robledillo. (2024, 16 abril). M03UF5AC2. M03UF5AC2. [Repositori](https://github.com/Pol-Robledillo/M03UF5AC3)
## IAs
Prompt: Que debo poner en el código de mi formulario para hacer saltar un error provider? Uso windows forms con c#.

Respuesta(Chat GPT): Para hacer saltar un errorProvider en un formulario de Windows Forms usando C#, puedes seguir estos pasos:

Agrega un control ErrorProvider a tu formulario desde la barra de herramientas de Windows Forms en Visual Studio.
En el evento donde deseas validar los datos (por ejemplo, al hacer clic en un botón de "Enviar" o al salir de un cuadro de texto), escribe código para validar los datos ingresados por el usuario.
Si la validación falla, utiliza el método SetError del control ErrorProvider para mostrar un mensaje de error asociado al control que falló la validación.
Aquí hay un ejemplo básico para validar un campo de texto llamado "textBoxNombre":

~~~
private void buttonEnviar_Click(object sender, EventArgs e)
{
    // Validar el campo de texto 'textBoxNombre'
    if (string.IsNullOrEmpty(textBoxNombre.Text))
    {
        errorProvider1.SetError(textBoxNombre, "El nombre es obligatorio");
    }
    else
    {
        // Limpiar el error si la validación es exitosa
        errorProvider1.SetError(textBoxNombre, "");
        
        // Aquí puedes continuar con el proceso de envío de datos
    }
}
~~~
En este ejemplo, si el campo de texto "textBoxNombre" está vacío, se establece un mensaje de error utilizando el método SetError del control ErrorProvider. De lo contrario, si el campo no está vacío, se limpia cualquier mensaje de error asociado.

Puedes adaptar este código según las necesidades de validación de tu formulario y los controles que estés utilizando.

