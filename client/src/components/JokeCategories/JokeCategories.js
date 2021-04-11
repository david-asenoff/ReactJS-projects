import { Component, React } from 'react';
import { Link, Router } from "react-router-dom";
import { Container, Row } from 'react-bootstrap';
import styles from './JokeCategories.module.css';
import JokeCategory from '../JokeCategory/JokeCategory';
import {getAll} from '../../services/jokeCategoriesService';

class JokeCategories extends Component {
  constructor(props) {
    super(props)

    this.state = {
      jokeCategories: [],
    }

  }

  async componentDidMount() {
    console.log('joke categories rendered');
    await getAll().then(x=>this.setState({jokeCategories: x}));
}

  render() {
    return (
      <>
      <div className={styles.rowcenter}>
{this.state.jokeCategories.map(x => {
  return <JokeCategory key={x.id} id={x.id} name={x.name} pictureUrl={x.pictureUrl} jokesCount={x.jokesCount}/>
})}
</div>
</>
    );
  }
}

export default JokeCategories;