# SimplePBKDF2

## WARNING
### PBKDF2 is considered insecure. Consider migrating to Argon2 for improved password security.

## Description

This library allows the easy use of PBKDF2.

## Usage

Hash password example:

```
  //generate a random password
  var password = "password";
  //or
  var password = Pbkdf2.GeneratePassword();
  
  //save this salt to the database
  var salt = Pbkdf2.GenerateSalt();

  //save this hash to the database
  string hashedpassword = Pbkdf2.Hash(password, salt);
```
