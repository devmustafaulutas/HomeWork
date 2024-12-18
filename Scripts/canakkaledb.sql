CREATE DATABASE IF NOT EXISTS CanakkaleDB DEFAULT CHARACTER SET utf8;
USE CanakkaleDB;

-- Roller tablosu
CREATE TABLE IF NOT EXISTS roles (
    id INT NOT NULL AUTO_INCREMENT,
    role VARCHAR(45) NOT NULL,
    PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Ülkeler tablosu
CREATE TABLE IF NOT EXISTS country (
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(45) NOT NULL,
    PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Şehirler tablosu
CREATE TABLE IF NOT EXISTS city (
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(45) NOT NULL,
    country_id INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (country_id) REFERENCES country(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- İlçeler tablosu
CREATE TABLE IF NOT EXISTS district (
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(45) NOT NULL,
    city_id INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (city_id) REFERENCES city(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Kullanıcılar tablosu
CREATE TABLE IF NOT EXISTS users (
    id INT NOT NULL AUTO_INCREMENT,
    username VARCHAR(45) NOT NULL,
    password VARCHAR(255) NOT NULL, -- Şifre için daha uzun VARCHAR
    email VARCHAR(100) NOT NULL,     -- Email için daha geniş alan
    role_id INT NOT NULL,
    city_id INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (role_id) REFERENCES roles(id),
    FOREIGN KEY (city_id) REFERENCES city(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Resimler tablosu
CREATE TABLE IF NOT EXISTS images (
    id INT NOT NULL AUTO_INCREMENT,
    url VARCHAR(255) NOT NULL,
    description VARCHAR(255),
    user_id INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (user_id) REFERENCES users(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Slider tablosu
CREATE TABLE IF NOT EXISTS slider (
    id INT NOT NULL AUTO_INCREMENT,
    title VARCHAR(100) NOT NULL,        -- Başlık için daha geniş alan
    description TEXT NOT NULL,          -- Açıklama için TEXT tipi
    image_id INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (image_id) REFERENCES images(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Permissions tablosu
CREATE TABLE IF NOT EXISTS permissions (
    id INT NOT NULL AUTO_INCREMENT,
    permission_name VARCHAR(100) NOT NULL,
    PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Role-Permissions pivot tablosu
CREATE TABLE IF NOT EXISTS role_permissions (
    role_id INT NOT NULL,
    permission_id INT NOT NULL,
    PRIMARY KEY (role_id, permission_id),
    FOREIGN KEY (role_id) REFERENCES roles(id),
    FOREIGN KEY (permission_id) REFERENCES permissions(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- User Profiles tablosu
CREATE TABLE IF NOT EXISTS user_profiles (
    user_id INT NOT NULL,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    phone_number VARCHAR(20),
    address TEXT,
    PRIMARY KEY (user_id),
    FOREIGN KEY (user_id) REFERENCES users(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Activity Logs tablosu
CREATE TABLE IF NOT EXISTS activity_logs (
    id INT NOT NULL AUTO_INCREMENT,
    user_id INT NOT NULL,
    activity VARCHAR(255) NOT NULL,
    timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (id),
    FOREIGN KEY (user_id) REFERENCES users(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Tags tablosu
CREATE TABLE IF NOT EXISTS tags (
    id INT NOT NULL AUTO_INCREMENT,
    tag_name VARCHAR(50) NOT NULL,
    PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Image_Tags pivot tablosu
CREATE TABLE IF NOT EXISTS image_tags (
    image_id INT NOT NULL,
    tag_id INT NOT NULL,
    PRIMARY KEY (image_id, tag_id),
    FOREIGN KEY (image_id) REFERENCES images(id),
    FOREIGN KEY (tag_id) REFERENCES tags(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Events tablosu
CREATE TABLE IF NOT EXISTS events (
    id INT NOT NULL AUTO_INCREMENT,
    title VARCHAR(100) NOT NULL,
    description TEXT,
    event_date DATE,
    location VARCHAR(100),
    PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dinamik veriler için örnek veri ekleme
INSERT INTO roles (role) VALUES ('Admin'), ('Editor'), ('User');
INSERT INTO country (name) VALUES ('Turkey');
INSERT INTO city (name, country_id) VALUES ('Canakkale', 1);
INSERT INTO district (name, city_id) VALUES ('Gökçeada', 1);
INSERT INTO users (username, password, email, role_id, city_id) VALUES ('admin', 'admin123', 'admin@example.com', 1, 1);
INSERT INTO images (url, description, user_id) VALUES ('https://example.com/image1.jpg', 'Example Image 1', 1);
INSERT INTO slider (title, description, image_id) VALUES ('Slider Title', 'Slider Description', 1);

-- Örnek veri ekleme
INSERT INTO permissions (permission_name) VALUES ('create_post'), ('edit_post'), ('delete_post');
INSERT INTO tags (tag_name) VALUES ('Nature'), ('History'), ('Culture');
