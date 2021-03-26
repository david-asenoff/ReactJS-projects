import { Component, React } from 'react';
import { Link, Router } from "react-router-dom";
import styles from './Body.module.css';
import { Container, Row } from 'react-bootstrap';
import Joke from '../Joke/Joke';

class Body extends Component {
  constructor(props) {
        super(props);
      } 
  render() {
    return (

  <div className={styles.rowcenter}>
  {this.props.categories.map(x => {
    return <Joke title={x.name} text={x.name.length} imageSource={x.picture}/>
  })}
  </div>

    );
  }
}

export default Body;