# CSharp-Mock-Framkwork-Comparison

I, being used to [FactoryGirl](https://github.com/thoughtbot/factory_girl) from the ruby world, wanted a better way to write and mock up objects in C#. 

Here is a comparison between some mocking frameworks.

# Mocking

## [Moq](https://github.com/Moq/moq4)

- Can only mock Virtual or Abstract Members!!!
- Actual Mocking (of properties, methods, etc)
- Not for object construction / does not work on read-only attributes


# Object Creation

## [Plant](https://github.com/jbrechtel/plant)

- Factories are called "Blueprints"
- suports overriding attributes
  - can be overridden in the test
  - even support overriding of read-only attributes

## [FactoryGirl](https://github.com/uchagani/factory-girl) (differnt from the above)

- Does not support overriding read-only attributes
- Factory definitions don't work with read-only attributes
  - Can be gotten around by creating the object normally, but setting different values for attributes for a particular test still wouldn't work.
