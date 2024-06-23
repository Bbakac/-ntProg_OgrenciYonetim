# Student Management System

This project is a simple Student Management System developed using ASP.NET Core MVC. The application allows adding, updating, deleting, and viewing student information. It uses example student data to perform basic CRUD (Create, Read, Update, Delete) operations.

## Features

- Add new students
- Update student information
- Delete students
- View student details

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQLite (or specify another database if used)

## Installation

### Prerequisites

- .NET SDK

### Steps

1. **Clone the repository:**

    ```sh
    git clone https://github.com/Bbakac/IntProg_OgrenciYonetim2.git
    cd IntProg_OgrenciYonetim2
    ```

2. **Build the project:**

    ```sh
    dotnet build
    ```

3. **Run the application:**

    ```sh
    dotnet run
    ```

4. **Open your browser and navigate to localhost:**

    Example: `http://localhost:5112`

## Project Structure

- **Controllers**
  - `HomeController.cs`: Manages the main page and general functions.
  - `OgrencilerController.cs`: Manages student operations.
- **Models**
  - `Ogrenciler.cs`: Defines the student model.
  - `ErrorViewModel.cs`: Defines error models.
- **Views**
  - **Ogrenciler**
    - `Index.cshtml`: Displays the list of students.
    - `Detay.cshtml`: Displays student details.
    - `Guncelle.cshtml`: Student update form.
    - `Sil.cshtml`: Student deletion confirmation.
    - `Yeni.cshtml`: New student registration form.
- **Program.cs**: Entry point of the application.

## Usage

- After starting the application, navigate to `http://localhost:5112` in your browser.
- On the main page, you can list, add, update, and delete students.

## Model Example

The student model used in the project is as follows:

- `OgrenciNo`: Student number
- `Ad`: Student's first name
- `Soyad`: Student's last name
- `Sınıf`: Student's class
- `Ders Tanımı`: Course description (e.g., Mathematics-1, Physics-2)
- `Kredi`: Course credit value
- `SınavTarihi`: Exam date
- `Vize Notu`: Midterm grade
- `Final Notu`: Final grade
- `Ortalama`: Average grade
- `Harf Karşılığı`: Letter grade (e.g., AA, BA)
- `Geçme Durumu`: Passing status (true/false)

### Example Students

1. Ali Yılmaz, 3rd grade, Mathematics (Mat-1), 3 credits, 10.06.2023, 85, 90, 87, AA, True
2. Ayşe Demir, 2nd grade, Physics (Fiz-2), 4 credits, 21.05.2023, 78, 82, 80, BB, True
3. Mehmet Çelik, 1st grade, Chemistry (Kim-1), 2 credits, 15.04.2023, 88, 79, 82, BA, True
4. Fatma Kara, 4th grade, Biology (Biy-1), 3 credits, 05.06.2023, 92, 85, 88, AA, True
5. Can Öztürk, 3rd grade, Literature (Ede-1), 2 credits, 30.03.2023, 55, 65, 61, DD, True

## Contributing

To contribute, please submit a pull request.
