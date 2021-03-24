import unittest
from subint import subint


class Subint(unittest.TestCase):

    def test_subint_happy_case(self):
        self.assertEqual([0, 1, 4], subint(1, [1, 11, 34, 52, 61]))

    def test_subint_sad_case(self):
        self.assertEqual([], subint(9, [1, 11, 34, 52, 61]))

if __name__ == '__main__':
    unittest.main()
