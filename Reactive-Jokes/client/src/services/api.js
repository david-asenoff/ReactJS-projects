const serverUrl = 'https://localhost:44319';

const getAllJokeCategories = `${serverUrl}/category/all`;
const getCategoryById = (x) => `${serverUrl}/category/${x}`;
const getAllJokesFromCategoryByCategoryId = (x) => `${serverUrl}/category/${x}/jokes`;

const getJokeByHisId = (x) => `${serverUrl}/joke/${x}`;
const deleteJokeByHisId = (x) => `${serverUrl}/joke/${x}`;
const updateByHisId = (x) => `${serverUrl}/joke/${x}`;
const createNewJoke = () => `${serverUrl}/joke/create`;


export {getAllJokeCategories, 
    getCategoryById, 
    getAllJokesFromCategoryByCategoryId, 
    getJokeByHisId, 
    deleteJokeByHisId, 
    updateByHisId,
    createNewJoke};