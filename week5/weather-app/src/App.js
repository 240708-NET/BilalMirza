import React from 'react';
import Weather from './Weather';
import './App.css';
const App = () => {
  return (
    <div className = "title">
      <h1>Weather Forecast App</h1>
      <Weather />
    </div>
  );
};

export default App;