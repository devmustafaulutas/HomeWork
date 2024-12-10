CREATE DATABASE IF NOT EXISTS db CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Veritabanını kullan
USE db;

-- Roller tablosunu oluştur
CREATE TABLE IF NOT EXISTS roles (
    id INT AUTO_INCREMENT PRIMARY KEY,         -- id sütunu otomatik artan birincil anahtar
    name VARCHAR(255) NOT NULL                 -- Rol adı
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Roller ekleme
INSERT INTO roles (name) 
VALUES ('admin'), ('friend'), ('user');

-- Kullanıcılar tablosunu oluştur
CREATE TABLE IF NOT EXISTS users (
    id INT AUTO_INCREMENT PRIMARY KEY,         -- id sütunu otomatik artan birincil anahtar
    username VARCHAR(255) NOT NULL,            -- Kullanıcı adı
    surname VARCHAR(255) NOT NULL,             -- Soyad
    password VARCHAR(255) NOT NULL,            -- Şifre
    email VARCHAR(255) NOT NULL,               -- Email
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP, -- Kaydın oluşturulma zamanı
    role_id INT,                               -- Kullanıcı rolü (foreign key)
    CONSTRAINT fk_role FOREIGN KEY (role_id) REFERENCES roles(id) -- Foreign key ilişkisi
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Örnek kullanıcı ekleme
INSERT INTO users (username, surname, password, email, created_at, role_id)
VALUES ('admin', 'admin', 'admin', 'mustafaum538@gmail.com', '2019-06-06 00:00:00', 1);
