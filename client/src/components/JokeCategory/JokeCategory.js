import { Component, React } from 'react';
import { Link, Router } from "react-router-dom";
import { Button, Card, Badge } from 'react-bootstrap';

class JokeCategory extends Component {
  constructor(props) {
        super(props);
      }    
  render() {
    return (
<Card style={{ width: '18rem' }} id={this.props.id} key={this.props.key}>
  <Card.Img variant="top" src={this.props.pictureUrl} />
  <Card.Body>
    <Card.Title>{this.props.name}
    <Badge pill variant="info">
    {this.props.jokesCount}
    </Badge>
    </Card.Title>
    <Button variant="primary">Разгледай</Button>
  </Card.Body>
</Card>
    );
  }
}

export default JokeCategory;