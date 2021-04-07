import {getJokeByHisId, deleteJokeByHisId} from './api';

export const getById = (x) => {
    return fetch(getJokeByHisId(x))
    .then(result => result.json())
    .catch( error=> console.log('Error returned from getting joke by id:'+ error));
};

export const deleteById = (x) => {
    return fetch(deleteJokeByHisId(x), { method: 'DELETE' })
    .then(result => result.json())
    .catch( error=> console.log('Error returned from getting joke by id:'+ error));
};