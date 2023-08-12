const path = require('path');

const fromRoot = (d) => path.join(__dirname, d);

module.exports = {
  roots: [
    fromRoot('apps/admin'),
    fromRoot('apps/web'),
    fromRoot('apps/server'),
  ],
  resetMocks: true,
  coveragePathIgnorePatterns: [],
  collectCoverageFrom: ['<rootDir>/src/**/*.{js,ts,tsx}'],
  coverageThreshold: null,
  testEnvironment: 'jsdom',
  transform: {
    '^.+\\.tsx?$': 'esbuild-jest',
    '^.+\\.jsx?$': 'esbuild-jest',
  },
  setupFilesAfterEnv: ['@testing-library/jest-dom'],
  moduleDirectories: ['node_modules'],
  moduleFileExtensions: ['js', 'jsx', 'json', 'ts', 'tsx'],
  moduleNameMapper: {
    '@src/(.*)': fromRoot('apps/web/src/$1'),
    '@src/(.*)': fromRoot('apps/admin/src/$1'),
  },
};
