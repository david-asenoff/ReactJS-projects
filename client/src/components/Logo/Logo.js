import { Component, React } from 'react';
import { Link, Router } from "react-router-dom";
import { Nav } from 'react-bootstrap';
import styles from './Logo.module.css';

class Logo extends Component {
  constructor(props) {
        super(props);
      }    
  render() {
    return (
    <span className={styles.logo}>Reactive Jokes</span>
     );
  }
}

export default Logo;