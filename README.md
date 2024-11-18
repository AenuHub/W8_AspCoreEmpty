## W8_AspCoreEmpty -- ASP.NET Core MVC Configuration Practice

This project is aiming to create an **ASP.NET Core Empty** project and configuring its structure to align with the **MVC design pattern**. The following tasks are done for this practice:

### Project Structure

### 1. **Controllers Folder**
- Create a folder named `Controllers` to house your controllers.

### 2. **Models Folder**
- Create a folder named `Models` to store your data models.

### 3. **Views Folder**
- Create a folder named `Views` for storing your view files.

### 4. **wwwroot Folder**
- Create a folder named `wwwroot` for static files like CSS, JavaScript, and images.

---

## Program.cs Configuration

The following configuration tasks performed in the `Program.cs` file:

### 1. **Adding MVC Services**
- Add the necessary services to enable MVC features, including support for controllers and views.

### 2. **Configuring Static File Usage**
- Configure the application to serve static files from the `wwwroot` folder.

### 3. **Routing Configuration**
- Set up routing to ensure incoming browser requests are correctly directed.

### 4. **Default Routing**
- Configure a default route for the homepage.

---

## Comments in Program.cs

At the bottom of `Program.cs`, the following information included as comments:
1. **Controller**: Define what a controller is and its purpose in MVC.
2. **Action**: Explain what an action is and how it is used within a controller.
3. **Model**: Describe the role of models in representing data.
4. **View**: Explain the function of views in rendering the user interface.
5. **Razor**: Provide an overview of Razor syntax and its role in ASP.NET Core.
6. **RazorView**: Differentiate between Razor and RazorView.
7. **wwwroot**: Explain the purpose of the `wwwroot` folder.
8. **builder.Build()**: Clarify what this method does during application startup.
9. **app.Run()**: Explain the role of this method in running the application.
