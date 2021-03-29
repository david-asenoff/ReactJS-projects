import api from './api';

export const getAll = () => {
    return fetch(api.getAllJokeCategories)
    .then(result => result.json())
    .catch( error=> console.log('Error returned from getting all jokes categories:'+ error));
};