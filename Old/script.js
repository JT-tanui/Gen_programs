$(document).ready(function() {
    // Function to add a new task
    function addTask() {
        var taskText = $('#taskInput').val();
        if (taskText !== '') {
            $('#taskList').append('<li>' + taskText + ' <button class="removeTaskBtn">Remove</button></li>');
            $('#taskInput').val('');
        }
    }

    // Function to remove a task
    $(document).on('click', '.removeTaskBtn', function() {
        $(this).parent().remove();
    });

    // Event listener for adding a task
    $('#addTaskBtn').click(function() {
        addTask();
    });

    // Event listener for pressing Enter key
    $('#taskInput').keypress(function(e) {
        if (e.which === 13) {
            addTask();
        }
    });
});


// $(document).ready(function() {...});: Ensures that the script executes after the document has loaded.
//     function addTask() {...}: Defines a function to add tasks to the list.
//     $(document).on('click', '.removeTaskBtn', function() {...});: Defines an event handler to remove tasks when the remove button is clicked.
//     $('#addTaskBtn').click(function() {...});: Adds an event listener to the "Add Task" button to call the addTask function when clicked.
//     $('#taskInput').keypress(function(e) {...});: Adds an event listener to the task input field to call the addTask function when the Enter key is pressed.