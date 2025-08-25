import React from 'react';
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';
import NightAllowance from './components/NightAllowanceForm';
import NightAllowanceTime from './components/NightAllowanceTimeForm';

const App: React.FC = () => {
    return (
        <Router>
            <div className="container mt-4">
                <nav className="mb-3">
                    <Link to="/night-allowance" className="btn btn-primary me-2">
                        Night Allowance
                    </Link>
                    <Link to="/night-allowance-time" className="btn btn-primary">
                        Night Allowance Time
                    </Link>
                </nav>
                <hr />
                <Routes>
                    <Route path="/night-allowance" element={<NightAllowance />} />
                    <Route path="/night-allowance-time" element={<NightAllowanceTime />} />
                </Routes>
            </div>
        </Router>
    );
};

export default App;
