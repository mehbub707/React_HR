import axios from "axios";

const baseUrl = 'http://localhost:19243/api/NightAllowanceTimes'; // আপনার backend port অনুযায়ী ঠিক করবেন

export const getAll = () => axios.get(baseUrl);

export const getById = (id: string) => axios.get(`${baseUrl}/${id}`);

export const create = (data: any) => axios.post(baseUrl, data);

export const update = (id: string, data: any) => axios.put(`${baseUrl}/${id}`, data);

export const deleteNightAllowanceTime = (id: string) => axios.delete(`${baseUrl}/${id}`);
export const generateNextId = () => axios.get(`${baseUrl}/GenerateNextId`);