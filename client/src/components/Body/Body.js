import { Component, React } from 'react';
import { Link, Router } from "react-router-dom";
import styles from './Body.module.css';
import { Container, Row } from 'react-bootstrap';
import JokeCategories from '../JokeCategories/JokeCategories';
import getAll from '../../services/jokeCategoriesService';

class Body extends Component {
  constructor(props) {
        super(props)

    this.state={
      jokeCategories:[],
    }
  } 

    componentDidMount(){
      getAll()
      .then(categories => {
      this.setState({jokeCategories: categories})
    });
  }
  render() {
    return (

  <div className={styles.rowcenter}>
  {this.props.jokeCategories.map(x => {
    return <JokeCategories title={x.name} text={x.name.length} imageSource={x.picture}/>
  })}
  </div>

    );
  }
}

export default Body;