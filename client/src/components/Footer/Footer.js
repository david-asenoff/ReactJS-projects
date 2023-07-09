import { Component } from 'react';
import styles from './Footer.module.css';
import Weather from '../../components/Weather/Weather';

class Footer extends Component {
  constructor(props) {
        super(props);
      }    
  render() {
    return (
      <>
      <Weather />
      <footer className="shadowbox">
          <p>{this.props.name}</p>
      </footer>
      </>
    );
  }
}

export default Footer;