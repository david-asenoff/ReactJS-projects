import { Component } from 'react';
import styles from './Footer.module.css';

class Footer extends Component {
  constructor(props) {
        super(props);
      }    
  render() {
    return (
      <footer className="shadowbox">
          <p>{this.props.name}</p>
      </footer>
    );
  }
}

export default Footer;