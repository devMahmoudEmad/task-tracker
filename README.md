# Simple Task Tracker

## Prerequisites
Before running this application, ensure you have the following:
- .NET Framework (version 4.6 or later) installed on your system. You can download it from the [official Microsoft website](https://dotnet.microsoft.com/en-us/download/dotnet-framework).

## Running the Application
1. Save the code in a C# file (e.g., `SimpleTaskTracker.cs`).
2. Open a command prompt or terminal and navigate to the directory where you saved the file.
3. Compile the code using a C# compiler (e.g., `csc SimpleTaskTracker.cs`). This will create an executable file named `SimpleTaskTracker.exe`.
4. Run the application by typing `SimpleTaskTracker.exe` in the command prompt.

## Using the Application

### Main Menu
The application presents a menu with the following options:
1. **ADD TASK**: Add a new task to your list.
2. **VIEW TASKS**: View all the tasks currently in your list.
3. **MARK A TASK COMPLETED**: Mark a completed task by entering its number.
4. **REMOVE TASK**: Remove a task from your list by entering its number.
5. **EXIT**: Exit the application.

### Adding Tasks
1. Select option 1 ("ADD TASK") from the menu.
2. Enter the description of the task you want to add.
3. Press Enter to confirm.
4. The task will be added to your list, and a confirmation message will be displayed.

### Viewing Tasks
1. Select option 2 ("VIEW TASKS") from the menu.
2. The application will display a numbered list of all your current tasks.

### Marking Tasks as Completed
1. Select option 3 ("MARK A TASK COMPLETED") from the menu.
2. Enter the number of the task you want to mark as completed.
3. The application will append "... Completed" to the task description.

### Removing Tasks
1. Select option 4 ("REMOVE TASK") from the menu.
2. Enter the number of the task you want to remove.

**Current Implementation:** While the code attempts to remove a task by setting its value to an empty string, this approach doesn't effectively remove the task from the list. 
we know that It's recommended to implement a more robust removal mechanism that shifts remaining tasks down in the array to maintain a contiguous list (refer to the "Future Enhancements" section for details).

### Exiting the Application
- Select option 5 ("EXIT") from the menu, or type `exit` and press Enter.
- The application will close.

## Future Enhancements
1. **Task Removal:** Implement a more effective removal strategy (e.g., shifting remaining tasks down in the array) to truly remove tasks from the list.
2. **Persistence:** Consider adding data persistence to save tasks to a file or database, allowing them to be retrieved even after the application is closed.
3. **Prioritization:** Allow users to prioritize tasks with levels (high, medium, low).
4. **Due Dates:** Enable setting due dates for tasks.
5. **User Interface:** Develop a graphical user interface (GUI) for a more user-friendly experience.
