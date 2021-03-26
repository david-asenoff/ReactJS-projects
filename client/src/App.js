import logo from './logo.svg';
import { Route, Switch } from "react-router-dom";
import Header from './components/Header/Header';
import Footer from './components/Footer/Footer'
import Body from './components/Body/Body'
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';


var categories = [
  {"name":"Big Brother", "picture":"https://vicove.com/theme/img/jokes-category/1.jpg"},
  {"name":"Microsoft", "picture":"https://vicove.com/theme/img/jokes-category/2.jpg"},
  {"name":"SMS", "picture":"https://vicove.com/theme/img/jokes-category/3.jpg"},
  {"name":"Авто", "picture":"https://vicove.com/theme/img/jokes-category/4.jpg"},
  {"name":"Блондинки", "picture":"https://vicove.com/theme/img/jokes-category/5.jpg"},
  {"name":"Графити", "picture":"https://vicove.com/theme/img/jokes-category/6.jpg"},
  {"name":"Животни", "picture":"https://vicove.com/theme/img/jokes-category/7.jpg"},
  {"name":"Знаете ли че...", "picture":"https://vicove.com/theme/img/jokes-category/8.jpg"},
  {"name":"Истории", "picture":"https://vicove.com/theme/img/jokes-category/9.jpg"},
  {"name":"Компютри", "picture":"https://vicove.com/theme/img/jokes-category/10.jpg"},
  {"name":"Лафоризми", "picture":"https://vicove.com/theme/img/jokes-category/11.jpg"},
  {"name":"Мечо Пух", "picture":"https://vicove.com/theme/img/jokes-category/12.jpg"},
  {"name":"Мръсни", "picture":"https://vicove.com/theme/img/jokes-category/13.jpg"},
  {"name":"Пиянски", "picture":"https://vicove.com/theme/img/jokes-category/14.jpg"},
  {"name":"По новините", "picture":"https://vicove.com/theme/img/jokes-category/15.jpg"},
  {"name":"Политически", "picture":"https://vicove.com/theme/img/jokes-category/16.jpg"},
  {"name":"Приказни", "picture":"https://vicove.com/theme/img/jokes-category/17.jpg"},
  {"name":"Професионални", "picture":"https://vicove.com/theme/img/jokes-category/18.jpg"},
  {"name":"Разни", "picture":"https://vicove.com/theme/img/jokes-category/19.jpg"},
  {"name":"С*кс", "picture":"https://vicove.com/theme/img/jokes-category/20.jpg"},
  {"name":"Само в България", "picture":"https://vicove.com/theme/img/jokes-category/1.jpg"},
  {"name":"Семейни", "picture":"https://vicove.com/theme/img/jokes-category/21.jpg"},
  {"name":"Спорт", "picture":"https://vicove.com/theme/img/jokes-category/22.jpg"},
  {"name":"Студентски", "picture":"https://vicove.com/theme/img/jokes-category/23.jpg"},
  {"name":"Ученически", "picture":"https://vicove.com/theme/img/jokes-category/24.jpg"},
  {"name":"Черен хумор", "picture":"https://vicove.com/theme/img/jokes-category/25.jpg"},
  {"name":"Чък Норис", "picture":"https://vicove.com/theme/img/jokes-category/26.jpg"},
  ];  
function App() {
  return (
    <div className="App">
      <Header name='Heading'></Header>
      <Body categories={categories}/>
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
