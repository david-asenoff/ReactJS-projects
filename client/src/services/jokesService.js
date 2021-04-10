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

export const updateById = (id) => {
    return fetch(updateByHisId(id), {
    headers: { 'Content-Type': 'application/json'},
    method: 'PUT' ,
    body: {id: id}})
    .then(result => result.json())
    .catch( error=> console.log('Error returned from getting joke by id:'+ error));
};

export const createJoke = (name, pictureUrl, content) => {
    return fetch(createNewJoke(), {
    headers: { 'Content-Type': 'application/json'},
    method: 'POST' ,
    body: JSON.stringify(name, pictureUrl, content)
                                    })
    .then(result => result.json())
    .catch( error=> console.log('Error returned from getting joke by id:'+ error));
};