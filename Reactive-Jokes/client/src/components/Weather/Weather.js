import ReactWeather, { useOpenWeather } from 'react-open-weather';

const Weather = () => {
    
  const { data, isLoading, errorMessage } = useOpenWeather({
    key: 'c2b968d9b22c330f0b04072839f48ffe',
    lat: '43.5726',
    lon: '27.8273',
    lang: 'bg',
    unit: 'metric', // values are (metric, standard, imperial)

  });
  return (
    <ReactWeather
      isLoading={isLoading}
      errorMessage={errorMessage}
      data={data}
      lang="bg"
      locationLabel="Добрич"
      unitsLabels={{ temperature: 'C', windSpeed: 'Km/h' }}
      showForecast
    />
  );
};
 export default Weather;