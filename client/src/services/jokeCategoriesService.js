import {getAllJokeCategories} from './api';

export const getAll = () => {
    return fetch(getAllJokeCategories)
    .then(result => result.json())
    .catch( error=> console.log('Error returned from getting all jokes categories:'+ error));
};