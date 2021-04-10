import { Component, React } from 'react';
import { Link, Router } from "react-router-dom";
import { Nav } from 'react-bootstrap';
import styles from './Logo.module.css';
import Weather from './../Weather/Weather'

class Logo extends Component {
  constructor(props) {
        super(props);
      }    
  render() {
    return (
      <>
    <span className={styles.logo}>Reactive Jokes</span>
    <Weather></Weather>
    </>
     );
  }
}

export default Logo;