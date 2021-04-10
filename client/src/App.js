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
import isAuth from "./components/Hoc/isAuth";
import Login from "./components/Login";
import Register from "./components/Register";
import { useState, useEffect } from "react";
import UserContext from "./contexts/UserContext";

function App() {
  const [user, setUser] = useState(null);
  const authInfo = {
    isAuthenticated: Boolean(user),
  };
  return (
    <div className="App">
      <UserContext.Provider value={{ userInfo: [user, setUser], authInfo: authInfo }}>
      <Header name='Heading'></Header>
      <Switch>
      <Router history={history}>
        <Route exact path="/" component={JokeCategories} />
        <Route exact path="/Login" component={Login} />
              <Route exact path="/Register" component={Register} />
              <Route
                exact
                path="/Logout"
                render={() => {
                  setUser((oldState) => (oldState = ""));
                  return <Redirect to="/" />;
                }}
              />
        <Route exact path="/About" component={About} />
        <Route exact path="/Category/:categoryId/Jokes" component={Jokes}/>
        <Route
                exact
                path="/Joke/:jokeId"
                component={isAuth(JokeDetails)}
              />
        <Route exact path="/Add/Joke" component={CreateJoke}/>
        </Router>
      </Switch>
      <Footer name='Copyright © 2021. Reactive Jokes'/>
      </UserContext.Provider>
    </div>
  );
}

export default App;
