# LR Publisher

LR Publisher is a graphical user interface designed for publishing resource description documents to a Learning Registry
node (https://github.com/LearningRegistry/LearningRegistry). It is designed to ease with development and testing of the
Learning Registry service APIs, as well as to familiarize new users to the data model of the LR. 

Features include:

- Ability to create and publish a resource data description document in a graphical environment.
- The ability to save documents created in the editor, as well as load existing documents.
- A history feature that keeps track of the documents that have been published using the tool.
- CSV import that allows you to map CSV rows to LR resource description fields, then publish all of the rows as individual documents.
- Digital signature support using LR-PGP 1.0

Feature requests are welcomed and may be filed as issues in this repository.

## Supported Systems / Dependencies

The following operating systems are supported for both development and runtime:

- Windows (requires gtk-sharp for development)
- OSX / Linux (requires mono)

## Installation

```bash
git clone https://github.com/adlnet/lr-publisher.git
cd lr-publisher
git submodule init
git submodule update
```

If you just want the binaries, you can find them in the [Downloads](https://github.com/adlnet/lr-publisher/downloads) section.