import logo from './logo.svg';
import {Route, Link, NavLink, Redirect, Switch, Router} from 'react-router-dom'
import Header from './components/Header/Header';
import Footer from './components/Footer/Footer';
import JokeCategories from './components/JokeCategories/JokeCategories';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import About from './components/About/About';
import Jokes from './components/Jokes/Jokes';
import JokeDetails from './components/JokeDetails/JokeDetails';
import CreateJoke from './components/CreateJoke/CreateJoke';
import history from './components/History/History';

function App() {
  return (
    <div className="App">
      <Header name='Heading'></Header>
      <Switch>
      <Router history={history}>
        <Route exact path="/" component={JokeCategories} />
        <Route exact path="/About" component={About} />
        <Route exact path="/Category/:categoryId/Jokes" component={Jokes}/>
        <Route exact path="/Joke/:jokeId" component={JokeDetails}/>
        <Route exact path="/Add/Joke" component={CreateJoke}/>
        </Router>
      </Switch>
      <Footer name='Copyright © 2021. Reactive Jokes'/>
    </div>
  );
}

export default App;
