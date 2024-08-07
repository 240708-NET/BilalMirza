import React, { useEffect, useState } from 'react';
import axios from 'axios';
import './Weather.css';
import { MagnifyingGlassIcon, BuildingOffice2Icon, GlobeAmericasIcon, MapPinIcon, FireIcon, ClipboardDocumentListIcon, EyeDropperIcon, CloudIcon} from '@heroicons/react/24/solid';



const Weather = () => {
  const [city, setCity] = useState('');
  const [weatherData, setWeatherData] = useState(null);

  const fetchData = async () => {
    try {
      const response = await axios.get(
        `https://freetestapi.com/api/v1/weathers?search=${city}`
      );
      setWeatherData(response.data);
      console.log(response.data); //You can see all the weather data in console log
    } catch (error) {
      console.error(error);
    }
  };

  useEffect(() => {
    fetchData();
  }, []);

  const handleInputChange = (e) => {
    setCity(e.target.value);
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    fetchData();
  };

  return (
    <div className="weather-container">
        <form className="weather-form" onSubmit={handleSubmit}>
            <input
            type="text"
            placeholder="Enter city name"
            value={city}
            onChange={handleInputChange}
            />
            <button type="submit">Get Weather</button>
        </form>
        {weatherData && city === weatherData[0].city ? (
            <div className="weather-data">
            <h2>{weatherData[0].name}</h2>
            <p><MagnifyingGlassIcon className="icon" /> ID: {weatherData[0].id}</p>
            <p><BuildingOffice2Icon className="icon" /> City: {weatherData[0].city}</p>
            <p><GlobeAmericasIcon className="icon" /> Country: {weatherData[0].country}</p>
            <p><MapPinIcon className="icon" /> Latitude | Longitude: {weatherData[0].latitude}, {weatherData[0].longitude}</p>
            {/* <p><MapPinIcon className="icon" /> Longitude: {weatherData[0].longitude}</p> */}
            <p><FireIcon className="icon" /> Temperature: {weatherData[0].temperature}°C</p>
            <p><ClipboardDocumentListIcon className="icon" /> Description: {weatherData[0].weather_description}</p>
            <p><EyeDropperIcon className="icon" /> Humidity: {weatherData[0].humidity}%</p>
            <p><CloudIcon className="icon" /> Wind Speed: {weatherData[0].wind_speed}m/s</p>
            </div>
        ) : (
            <p>Loading weather data...</p>
        )}
    </div>
  );
};

export default Weather;