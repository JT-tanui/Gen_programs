$(document).ready(function() {
    var currentQuestion = 0;
    var score = 0;

    var quizQuestions = [
        {
            question: "What is the capital of France?",
            options: ["Paris", "London", "Berlin", "Rome"],
            answer: "Paris"
        },
        {
            question: "Who wrote 'Romeo and Juliet'?",
            options: ["William Shakespeare", "Jane Austen", "Charles Dickens", "Leo Tolstoy"],
            answer: "William Shakespeare"
        },
        {
            question: "What is the chemical symbol for water?",
            options: ["H2O", "CO2", "NaCl", "O2"],
            answer: "H2O"
        }
    ];

    function displayQuestion() {
        var questionObj = quizQuestions[currentQuestion];
        $('#question').text(questionObj.question);
        $('#options').empty();
        questionObj.options.forEach(function(option) {
            $('#options').append('<input type="radio" name="option" value="' + option + '"> ' + option + '<br>');
        });
    }

    function checkAnswer() {
        var selectedOption = $('input[name="option"]:checked').val();
        if (selectedOption === quizQuestions[currentQuestion].answer) {
            $('#result').text("Correct!");
            score++;
        } else {
            $('#result').text("Incorrect! The correct answer is: " + quizQuestions[currentQuestion].answer);
        }
        $('#result').show();
    }

    $('#nextBtn').click(function() {
        if (currentQuestion < quizQuestions.length - 1) {
            currentQuestion++;
            displayQuestion();
            $('#result').hide();
        } else {
            var percentageScore = (score / quizQuestions.length) * 100;
            $('#question').text("Quiz Completed!");
            $('#options').empty();
            $('#nextBtn').hide();
            $('#result').text("Your score: " + score + " out of " + quizQuestions.length + " (" + percentageScore + "%)");
            $('#result').show();
        }
    });

    displayQuestion();
});
