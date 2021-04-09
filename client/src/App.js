import logo from './logo.svg';
import {Route, Link, NavLink, Redirect, Switch} from 'react-router-dom'
import Header from './components/Header/Header';
import Footer from './components/Footer/Footer';
import JokeCategories from './components/JokeCategories/JokeCategories';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import About from './components/About/About';
import Jokes from './components/Jokes/Jokes';
import JokeDetails from './components/JokeDetails/JokeDetails'

function App() {
  return (
    <div className="App">
      <Header name='Heading'></Header>
      <Switch>
        <Route exact path="/" component={JokeCategories} />
        <Route exact path="/About" component={About} />
        <Route exact path="/Category/:categoryId/Jokes" component={Jokes}/>
        <Route exact path="/Joke/:jokeId" component={JokeDetails}/>
      </Switch>
      <Footer name='Copyright © 2021. Reactive Jokes'/>
    </div>
  );
}

export default App;
