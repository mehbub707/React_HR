
import React, { useEffect, useState } from "react";
import {
    getAll,
    getById,
    create,
    update,
    deleteNightAllowanceTime,
    generateNextId,
} from "../services/nightAllowanceTimeService";

interface NightAllowanceTime {
    nightAllowanceTimeID: string;
    startDate: string;
    endDate: string;
    allowanceType: string;
    nightHours: string;
    nightMinutes: string;
    employmentTypeID: string;
}

const NightAllowanceTimePage: React.FC = () => {
    const [data, setData] = useState<NightAllowanceTime[]>([]);
    const [formData, setFormData] = useState<NightAllowanceTime>({
        nightAllowanceTimeID: "",
        startDate: new Date().toISOString().split("T")[0],
        endDate: new Date().toISOString().split("T")[0],
        allowanceType: "",
        nightHours: "",
        nightMinutes: "",
        employmentTypeID: "",
    });
    const [isEditing, setIsEditing] = useState(false);
    const [search, setSearch] = useState("");

    // Dropdown options — প্রয়োজন অনুসারে পরিবর্তন করো
    const allowanceTypeOptions = ["Type A", "Type B", "Type C"];
    const nightHoursOptions = Array.from({ length: 13 }, (_, i) => i.toString()); // 0 থেকে 12
    const nightMinutesOptions = ["0", "15", "30", "45"];
    const employmentTypeOptions = ["EMP_TYPE_001", "EMP_TYPE_002", "EMP_TYPE_003"]; // তোমার এমপ্লয়মেন্ট টাইপ গুলো

    const loadData = async () => {
        try {
            const res = await getAll();
            setData(res.data);
        } catch (error) {
            console.error("Error loading data:", error);
        }
    };

    const loadNextId = async () => {
        try {
            const res = await generateNextId();
            setFormData((prev) => ({ ...prev, nightAllowanceTimeID: res.data }));
        } catch (error) {
            console.error("Error generating next ID:", error);
        }
    };

    useEffect(() => {
        loadData();
        if (!isEditing) {
            loadNextId();
        }
    }, [isEditing]);

    const handleChange = (
        e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>
    ) => {
        const { name, value } = e.target;
        setFormData((prev) => ({ ...prev, [name]: value }));
    };

    const resetForm = () => {
        setFormData({
            nightAllowanceTimeID: "",
            startDate: new Date().toISOString().split("T")[0],
            endDate: new Date().toISOString().split("T")[0],
            allowanceType: "",
            nightHours: "",
            nightMinutes: "",
            employmentTypeID: "",
        });
        setIsEditing(false);
        loadNextId();
    };

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        try {
            if (isEditing) {
                await update(formData.nightAllowanceTimeID, formData);
            } else {
                await create(formData);
            }
            resetForm();
            loadData();
        } catch (error) {
            console.error("Error saving record:", error);
        }
    };

    const handleEdit = async (id: string) => {
        try {
            const res = await getById(id);
            const record = {
                ...res.data,
                startDate: res.data.startDate.split("T")[0],
                endDate: res.data.endDate.split("T")[0],
            };
            setFormData(record);
            setIsEditing(true);
        } catch (error) {
            console.error("Error loading record:", error);
        }
    };

    const handleDelete = async (id: string) => {
        if (!window.confirm("Are you sure you want to delete this record?")) return;
        try {
            await deleteNightAllowanceTime(id);
            resetForm();
            loadData();
        } catch (error) {
            console.error("Error deleting record:", error);
        }
    };

    return (
        <div className="container mt-3">
            <h6>Night Allowance Time Records</h6>

            <div className="card mt-2">
                <div className="card-header">{isEditing ? "Edit Record" : "Add Record"}</div>
                <div className="card-body">
                    <form onSubmit={handleSubmit}>
                        <div className="row">

                            {/* ID (Readonly, auto generated) */}
                            <div className="col-md-6 mb-3">
                                <label>Night Allowance Time ID</label>
                                <input
                                    type="text"
                                    name="nightAllowanceTimeID"
                                    value={formData.nightAllowanceTimeID}
                                    readOnly
                                    className="form-control"
                                    required
                                />
                            </div>

                            {/* Start Date */}
                            <div className="col-md-6 mb-3">
                                <label>Start Date</label>
                                <input
                                    type="date"
                                    name="startDate"
                                    value={formData.startDate}
                                    onChange={handleChange}
                                    className="form-control"
                                    required
                                />
                            </div>

                            {/* End Date */}
                            <div className="col-md-6 mb-3">
                                <label>End Date</label>
                                <input
                                    type="date"
                                    name="endDate"
                                    value={formData.endDate}
                                    onChange={handleChange}
                                    className="form-control"
                                    required
                                />
                            </div>

                            {/* Allowance Type Dropdown */}
                            <div className="col-md-6 mb-3">
                                <label>Allowance Type</label>
                                <select
                                    name="allowanceType"
                                    value={formData.allowanceType}
                                    onChange={handleChange}
                                    className="form-control"
                                    required
                                >
                                    <option value="">-- Select Allowance Type --</option>
                                    {allowanceTypeOptions.map((option) => (
                                        <option key={option} value={option}>
                                            {option}
                                        </option>
                                    ))}
                                </select>
                            </div>

                            {/* Night Hours Dropdown */}
                            <div className="col-md-6 mb-3">
                                <label>Night Hours</label>
                                <select
                                    name="nightHours"
                                    value={formData.nightHours}
                                    onChange={handleChange}
                                    className="form-control"
                                    required
                                >
                                    <option value="">-- Select Hours --</option>
                                    {nightHoursOptions.map((hour) => (
                                        <option key={hour} value={hour}>
                                            {hour}
                                        </option>
                                    ))}
                                </select>
                            </div>

                            {/* Night Minutes Dropdown */}
                            <div className="col-md-6 mb-3">
                                <label>Night Minutes</label>
                                <select
                                    name="nightMinutes"
                                    value={formData.nightMinutes}
                                    onChange={handleChange}
                                    className="form-control"
                                    required
                                >
                                    <option value="">-- Select Minutes --</option>
                                    {nightMinutesOptions.map((min) => (
                                        <option key={min} value={min}>
                                            {min}
                                        </option>
                                    ))}
                                </select>
                            </div>

                            {/* Employment Type ID Dropdown */}
                            <div className="col-md-6 mb-3">
                                <label>Employment Type ID</label>
                                <select
                                    name="employmentTypeID"
                                    value={formData.employmentTypeID}
                                    onChange={handleChange}
                                    className="form-control"
                                    required
                                >
                                    <option value="">-- Select Employment Type --</option>
                                    {employmentTypeOptions.map((option) => (
                                        <option key={option} value={option}>
                                            {option}
                                        </option>
                                    ))}
                                </select>
                            </div>

                            {/* Buttons */}
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

            {/* Search input */}
            <div className="my-3">
                <input
                    type="text"
                    placeholder="Search by Allowance Type or Employment Type"
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
                        <th>Start Date</th>
                        <th>End Date</th>
                        <th>Allowance Type</th>
                        <th>Night Hours</th>
                        <th>Night Minutes</th>
                        <th>Employment Type ID</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
                    {data
                        .filter(
                            (item) =>
                                item.allowanceType.toLowerCase().includes(search.toLowerCase()) ||
                                item.employmentTypeID.toLowerCase().includes(search.toLowerCase())
                        )
                        .map((item) => (
                            <tr key={item.nightAllowanceTimeID}>
                                <td>{item.nightAllowanceTimeID}</td>
                                <td>{item.startDate}</td>
                                <td>{item.endDate}</td>
                                <td>{item.allowanceType}</td>
                                <td>{item.nightHours}</td>
                                <td>{item.nightMinutes}</td>
                                <td>{item.employmentTypeID}</td>
                                <td>
                                    <button
                                        className="btn btn-warning btn-sm me-2"
                                        onClick={() => handleEdit(item.nightAllowanceTimeID)}
                                    >
                                        Edit
                                    </button>
                                    <button
                                        className="btn btn-danger btn-sm"
                                        onClick={() => handleDelete(item.nightAllowanceTimeID)}
                                    >
                                        Delete
                                    </button>
                                </td>
                            </tr>
                        ))}
                </tbody>
            </table>
        </div>
    );
};

export default NightAllowanceTimePage;
