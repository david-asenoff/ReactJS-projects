import {getJokeByHisId, deleteJokeByHisId, updateByHisId, createNewJoke} from './api';

export const getById = (x) => {
    return fetch(getJokeByHisId(x))
    .then(result => result.json())
    .catch( error=> console.log('Error returned from getting joke by id:'+ error));
};

export const deleteById = (x) => {
    return fetch(deleteJokeByHisId(x), 
    { method: 'DELETE' })
    .then(result => result.json())
    .catch( error=> console.log('Error returned from getting joke by id:'+ error));
};

export const updateById = (x) => {
    return fetch(updateByHisId(x.id), {
    method: 'PUT' ,
    headers: { 'Content-Type': 'application/json'},
    body: JSON.stringify(x)
                                    })
    .then(result => result.json())
    .catch( error=> console.log('Error returned from updating joke by id:'+ error));
};

export const createJoke = (x) => {
    return fetch("https://localhost:44319/joke/create", {
    method: 'POST' ,
    headers: { 'Content-Type': 'application/json'},
    body: JSON.stringify(x)
                                    })
    .then(result => result.json())
    .catch( error=> console.log('Error returned from getting joke by id:'+ error));
};