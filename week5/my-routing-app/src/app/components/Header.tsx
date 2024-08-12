import React from 'react';
import Link from 'next/link';
import NavLinks from './NavLink'
import styles from '../styles/HeaderStyle.module.css'

const Header: React.FC = () => {
    return (
        <header>
            <nav className={styles.navigation}>
                <div className={styles.logoContainer}>
                    <Link href="/chicken" className={styles.logo}>
                        <img src="next.svg" alt="Logo" />
                        My<span>Routing</span>Demo
                    </Link>
                </div>

                <ul className={styles.menuContainer}>
                    <NavLinks />
                </ul>
            </nav>
        </header>
    );
};

export default Header;
