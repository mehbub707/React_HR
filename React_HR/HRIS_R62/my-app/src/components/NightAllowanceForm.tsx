import React, { useEffect, useState } from "react";
import {
    getAll,
    getById,
    create,
    update,
    deleteNightAllowance,

} from "../services/nightAllowanceService";
import NightAllowanceTimeForm from "./NightAllowanceTimeForm";

interface NightAllowance {
    nightAllowanceID: string;
    salaryMinimum: number;
    salaryMaximum: number;
    nightAllowanceRate: string;
    employmentTypeID: string;
}

const NightAllowanceForm: React.FC = () => {
    const [nightAllowances, setNightAllowances] = useState<NightAllowance[]>([]);
    const [search, setSearch] = useState("");
    const [pageNumber, setPageNumber] = useState(1);
    const [pageSize] = useState(5);
    const [totalRecords, setTotalRecords] = useState(0);

    const [formData, setFormData] = useState<NightAllowance>({
        nightAllowanceID: "",
        salaryMinimum: 0,
        salaryMaximum: 0,
        nightAllowanceRate: "",
        employmentTypeID: "",
    });

    const [isEditing, setIsEditing] = useState(false);

    // Load data function
    const loadData = async () => {
        try {
            const res = await getAll();
            setNightAllowances(res.data);
            setTotalRecords(res.data.length);
        } catch (error) {
            console.error("Error loading night allowances:", error);
        }
    };

    useEffect(() => {
        loadData();
    }, []);

    const handleChange = (
        e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>
    ) => {
        const { name, value } = e.target;
        setFormData((prev) => ({
            ...prev,
            [name]:
                name === "salaryMinimum" || name === "salaryMaximum"
                    ? Number(value)
                    : value,
        }));
    };

    const resetForm = () => {
        setFormData({
            nightAllowanceID: "",
            salaryMinimum: 0,
            salaryMaximum: 0,
            nightAllowanceRate: "",
            employmentTypeID: "",
        });
        setIsEditing(false);
    };

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        try {
            if (isEditing) {
                await update(formData.nightAllowanceID, formData);
            } else {
                await create(formData);
            }
            resetForm();
            loadData();
        } catch (error) {
            console.error("Error saving night allowance:", error);
        }
    };

    const handleEdit = async (id: string) => {
        try {
            const res = await getById(id);
            setFormData(res.data);
            setIsEditing(true);
        } catch (error) {
            console.error("Error loading record:", error);
        }
    };

    const handleDelete = async (id: string) => {
        if (!window.confirm("Are you sure you want to delete this record?")) return;
        try {
            await deleteNightAllowance(id);
            resetForm();
            loadData();
        } catch (error) {
            console.error("Error deleting record:", error);
        }
    };

    return (
        <div className="container mt-3">
            <h6>Night Allowance Records</h6>

            {/* Form */}
            <div className="card mt-2">
                <div className="card-header">{isEditing ? "Edit Record" : "Add Record"}</div>
                <div className="card-body">
                    <form onSubmit={handleSubmit}>
                        <div className="row">

                            <div className="col-md-6 mb-3">
                                <label>Night Allowance ID</label>
                                <input
                                    type="text"
                                    name="nightAllowanceID"
                                    value={formData.nightAllowanceID}
                                    onChange={handleChange}
                                    className="form-control"
                                    required={!isEditing} // required only when creating
                                    disabled={isEditing} // disable editing ID
                                />
                            </div>

                            <div className="col-md-6 mb-3">
                                <label>Salary Minimum</label>
                                <input
                                    type="number"
                                    name="salaryMinimum"
                                    value={formData.salaryMinimum}
                                    onChange={handleChange}
                                    className="form-control"
                                    required
                                />
                            </div>

                            <div className="col-md-6 mb-3">
                                <label>Salary Maximum</label>
                                <input
                                    type="number"
                                    name="salaryMaximum"
                                    value={formData.salaryMaximum}
                                    onChange={handleChange}
                                    className="form-control"
                                    required
                                />
                            </div>

                            <div className="col-md-6 mb-3">
                                <label>Night Allowance Rate</label>
                                <input
                                    type="text"
                                    name="nightAllowanceRate"
                                    value={formData.nightAllowanceRate}
                                    onChange={handleChange}
                                    className="form-control"
                                    required
                                />
                            </div>

                            <div className="col-md-6 mb-3">
                                <label>Employment Type ID</label>
                                <input
                                    type="text"
                                    name="employmentTypeID"
                                    value={formData.employmentTypeID}
                                    onChange={handleChange}
                                    className="form-control"
                                    required
                                />
                            </div>

                            <div className="col-6">
                                <button
                                    type="button"
                                    className="btn btn-outline-secondary w-100"
                                    onClick={resetForm}
                                >
                                    Reset
                                </button>
                            </div>

                            <div className="col-6">
                                <button className="btn btn-success w-100" type="submit">
                                    {isEditing ? "Update" : "Save"}
                                </button>
                            </div>

                        </div>
                    </form>
                </div>
            </div>

            {/* Search */}
            <div className="my-3">
                <input
                    type="text"
                    placeholder="Search by Rate or Employment Type"
                    className="form-control"
                    value={search}
                    onChange={(e) => setSearch(e.target.value)}
                />
            </div>

            {/* Table */}
            <table className="table table-bordered">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Salary Minimum</th>
                        <th>Salary Maximum</th>
                        <th>Rate</th>
                        <th>Employment Type ID</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
                    {nightAllowances
                        .filter(
                            (item) =>
                                item.nightAllowanceRate.toLowerCase().includes(search.toLowerCase()) ||
                                item.employmentTypeID.toLowerCase().includes(search.toLowerCase())
                        )
                        .map((item) => (
                            <tr key={item.nightAllowanceID}>
                                <td>{item.nightAllowanceID}</td>
                                <td>{item.salaryMinimum}</td>
                                <td>{item.salaryMaximum}</td>
                                <td>{item.nightAllowanceRate}</td>
                                <td>{item.employmentTypeID}</td>
                                <td>
                                    <button
                                        className="btn btn-warning btn-sm me-2"
                                        onClick={() => handleEdit(item.nightAllowanceID)}
                                    >
                                        Edit
                                    </button>
                                    <button
                                        className="btn btn-danger btn-sm"
                                        onClick={() => handleDelete(item.nightAllowanceID)}
                                    >
                                        Delete
                                    </button>
                                </td>
                            </tr>
                        ))}
                </tbody>
            </table>

            {/* Pagination buttons */}
            {/* (Optional: you can add pagination handling here) */}
        </div>
    );
};

export default NightAllowanceTimeForm;
