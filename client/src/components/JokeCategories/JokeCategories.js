import { Component, React } from 'react';
import { Link, Router } from "react-router-dom";
import { Button, Card, Badge } from 'react-bootstrap';

class JokeCategories extends Component {
  constructor(props) {
        super(props);
      }    
  render() {
    return (
<Card style={{ width: '18rem' }}>
  <Card.Img variant="top" src={this.props.imageSource} />
  <Card.Body>
    <Card.Title>{this.props.title}
    <Badge pill variant="info">
    {this.props.text}
    </Badge>
    </Card.Title>
    <Button variant="primary">Go somewhere</Button>
  </Card.Body>
</Card>
    );
  }
}

export default JokeCategories;