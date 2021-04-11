import { React, useContext } from "react";
import UserContext from "../../contexts/UserContext";
import { Link, Router } from "react-router-dom";
import { Nav } from 'react-bootstrap';
import styles from './Header.module.css';
import Logo from "../Logo/Logo";

const Header = () => {
  const { authInfo } = useContext(UserContext);
  const { isAuthenticated } = authInfo;
  return (
    <div>
      <Nav fill variant="tabs" defaultActiveKey="/home">
        {!isAuthenticated ? (
          <>
            <Nav.Item>
              <Nav.Link href="/Login">Вход</Nav.Link>
            </Nav.Item>
            <Nav.Item>
              <Nav.Link href="/Register">Регистрация</Nav.Link>
            </Nav.Item>
          </>
        ) :
          <>
            <Nav.Item>
              <Nav.Link href="/">Начало</Nav.Link>
            </Nav.Item>
            <Nav.Item>
              <Nav.Link href="/about">Контакти</Nav.Link>
            </Nav.Item>
            <Nav.Item>
              <Nav.Link href="/add/joke">Добави</Nav.Link>
            </Nav.Item>
            <Nav.Item>
              <Nav.Link href="/Logout">Изход</Nav.Link>
            </Nav.Item>
          </>
        }
      </Nav>
      <Logo />
    </div>
  );
};

export default Header;