import axios from "axios";

const baseUrl = 'http://localhost:19243/api/NightAllowances';  // আপনার backend port এবং route অনুযায়ী পরিবর্তন করুন

// সকল Night Allowance পেজিনেশন বা সার্চ ছাড়া আনতে চাইলে (আপনি চাইলে পরবর্তীতে পেজিং যোগ করতে পারবেন)
export const getAll = () => {
    return axios.get(baseUrl);
};

export const getById = (id: string) => axios.get(`${baseUrl}/${id}`);

export const create = (data: any) => axios.post(baseUrl, data);

export const update = (id: string, data: any) => axios.put(`${baseUrl}/${id}`, data);

export const deleteNightAllowance = (id: string) => axios.delete(`${baseUrl}/${id}`);
