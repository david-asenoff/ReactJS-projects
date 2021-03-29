import logo from './logo.svg';
import { Route, Switch } from "react-router-dom";
import Header from './components/Header/Header';
import Footer from './components/Footer/Footer'
import Body from './components/Body/Body'
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';

function App() {
  return (
    <div className="App">
      <Header name='Heading'></Header>
      <Body/>
      <Footer name='Copyright © 2021. Reactive Jokes'/>
      {/* <Switch>
        <Route exact path="/" component={Header} />
        <Route exact path="/Login" component={Header} />
        <Route exact path="/Register" component={Header} />
        <Route exact path="/Logout" component={Header} />
        <Route exact path="/Posts/Details/:postId" component={Header} />
      </Switch> */}
    </div>
  );
}

export default App;
