import {getAllJokeCategories, getCategoryById, getAllJokesFromCategoryByCategoryId} from './api';

export const getAll = () => {
    return fetch(getAllJokeCategories)
    .then(result => result.json())
    .catch( error=> console.log('Error returned from getting all jokes categories:'+ error));
};

export const getById = () => {
    return fetch(getCategoryById)
    .then(result => result.json())
    .catch( error=> console.log('Error returned from getting category by id:'+ error));
};

export const getJokesByCategoryId = (x) => {
    return fetch(getAllJokesFromCategoryByCategoryId(x))
    .then(result => result.json())
    .catch( error=> console.log('Error returned from getting all jokes by category id:'+ error));
};