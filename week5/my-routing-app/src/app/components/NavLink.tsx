'use client';

import React from 'react';
import Link from 'next/link';
import { usePathname } from 'next/navigation'; // Import usePathname to get the current route
import { HomeIcon, AtSymbolIcon, RocketLaunchIcon } from '@heroicons/react/24/outline';
import styles from '../styles/HeaderStyle.module.css'

const links = [
  { name: 'Home', href: '/', icon: HomeIcon },
  { name: 'About', href: '/about', icon: AtSymbolIcon },
  { name: 'My Page', href: '/my-page', icon: RocketLaunchIcon },
];

export default function NavLinks() {
  const pathname = usePathname(); // Get the current pathname

  return (
    <ul className={styles.menuContainer}>
      {links.map((link) => {
        const LinkIcon = link.icon;
        const isActive = pathname === link.href; // Check if the link is active

        return (
          <li key={link.name}>
            <Link href={link.href} className={isActive ? 'active' : ''}>
              <LinkIcon className={styles.icon} />
              {link.name}
            </Link>
          </li>
        );
      })}
    </ul>
  );
}
