$(document).ready(function() {
    $('#searchBtn').click(function() {
        var location = $('#locationInput').val();
        if (location.trim() !== '') {
            getWeather(location);
        }
    });

    function getWeather(location) {
        var apiKey = 'YOUR_API_KEY'; // Replace with your API key
        var apiUrl = 'https://api.openweathermap.org/data/2.5/weather?q=' + location + '&appid=' + apiKey;

        $.ajax({
            url: apiUrl,
            type: 'GET',
            dataType: 'json',
            success: function(response) {
                displayWeather(response);
            },
            error: function(error) {
                $('#weatherInfo').html('<p>Error: Unable to fetch weather data. Please try again later.</p>');
            }
        });
    }

    function displayWeather(data) {
        var weatherInfo = '<h2>Current Weather in ' + data.name + '</h2>';
        weatherInfo += '<p>Description: ' + data.weather[0].description + '</p>';
        weatherInfo += '<p>Temperature: ' + (data.main.temp - 273.15).toFixed(2) + '°C</p>';
        weatherInfo += '<p>Humidity: ' + data.main.humidity + '%</p>';
        weatherInfo += '<p>Wind Speed: ' + data.wind.speed + ' m/s</p>';
        $('#weatherInfo').html(weatherInfo);
    }
});
