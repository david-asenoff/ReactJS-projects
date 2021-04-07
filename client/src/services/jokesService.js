import {getJokeByHisId} from './api';

export const getById = () => {
    return fetch(getJokeByHisId)
    .then(result => result.json())
    .catch( error=> console.log('Error returned from getting joke by id:'+ error));
};