import { Component, React } from 'react';
import { Link, Router } from "react-router-dom";
import { Nav } from 'react-bootstrap';
import styles from './Header.module.css';
import Logo from "../Logo/Logo";

class Header extends Component {
  constructor(props) {
        super(props);
      }    
  render() {
    return (
      <div>

<Nav fill variant="tabs" defaultActiveKey="/home">

  <Nav.Item>
    <Nav.Link href="/home">Начало</Nav.Link>
  </Nav.Item>
  <Nav.Item>
    <Nav.Link href="/home">Вицове</Nav.Link>
  </Nav.Item>
  <Nav.Item>
    <Nav.Link href="/home">Контакти</Nav.Link>
  </Nav.Item>
  <Nav.Item>
    <Nav.Link href="/home">Вход</Nav.Link>
  </Nav.Item>
  <Nav.Item>
    <Nav.Link href="/home">Добави</Nav.Link>
  </Nav.Item>
</Nav>
<Logo/>
</div>
    );
  }
}

export default Header;